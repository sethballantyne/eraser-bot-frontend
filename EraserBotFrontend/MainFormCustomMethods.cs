/*
*Copyright (c) 2011 Seth Ballantyne <seth.ballantyne@gmail.com>
*
*Permission is hereby granted, free of charge, to any person obtaining a copy
*of this software and associated documentation files (the "Software"), to deal
*in the Software without restriction, including without limitation the rights
*to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
*copies of the Software, and to permit persons to whom the Software is
*furnished to do so, subject to the following conditions:
*
*The above copyright notice and this permission notice shall be included in
*all copies or substantial portions of the Software.
*
*THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
*IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
*FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
*AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
*LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
*OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
*THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EraserBotFrontend.Paths;

namespace EraserBotFrontend
{
    /// <summary>
    /// Part of MainForm containing all custom / refactored methods. In short,
    /// the files had to be split up as it was getting a bit cramped.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Stores controls in the specified buffer which should be subsequently passed
        /// to the appropriate page for rendering.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="hostForm"></param>
        void AllocateBufferIfUnallocated(ref Control[] buffer, Form hostForm)
        {
            // Buffer has to be allocated because ControlCollection can't be readily
            // converted to an array (there's no ControlCollection.ToArray() for example).
            // Just saves having to write out the buffer allocation and copy code over and over
            // again
            if (buffer == null)
            {
                buffer = new Control[hostForm.Controls.Count];
                hostForm.Controls.CopyTo(buffer, 0);
            }
        }

        /// <summary>
        /// Generates the bot related command line arguments based on the options 
        /// selected by the user.
        /// </summary>
        /// <returns>A string containing the bot related
        ///  command line arguments</returns>
        private string GenerateBotArgs()
        {
            int botSelectionIndex = botSelectionComboBox.SelectedIndex;

            //int botSkill = skill
            // random bots
            if (botSelectionIndex == 0)
            {
                int numBots = randomBotSelection.NumBotsSelected();
                return "+set bot_num " + numBots.ToString() + " ";
            }

            // specific bots
            return "+sv bots " + specificBotSelection.SelectedBots + " ";

        }

        /// <summary>
        /// Writes map.txt to the Eraser Bot directory, containing all the selected maps.
        /// In order to play on more than one map without disconnecting the server 
        /// (which is what the console map command does) , the desired maps have to be written to a
        /// file called map.txt and stored in the mods basedir, or if your playing vanilla Q2,
        /// in Quake2's base directory.
        /// 
        /// </summary>
        /// <returns>A formatted command line argument containing the first map in the cycle.
        /// This is required, so the game knows where to start. No map argument, no game.</returns>
        private string GenerateMapArgs()
        {
            if (EraserPaths.Base != string.Empty)
            {
                using (StreamWriter sw = new StreamWriter(EraserPaths.Base + @"//maps.txt", false, Encoding.ASCII))
                {
                    for (int i = 0; i < selectedMapsListBox.Items.Count; i++)
                    {
                        sw.WriteLine(selectedMapsListBox.Items[i] as string);
                    }

                    sw.Close();
                }

                return "+map " + selectedMapsListBox.Items[0] as string + " ";
            }

            return null;
        }

        /// <summary>
        /// Determines whether any bots are set to be generated once the game is launched. 
        /// Used when the user clicks the 'launch' button.
        /// </summary>
        /// <returns>true if the user has selected bots, else returns false</returns>
        private bool BotsAreSelected()
        {
            if (botSelectionComboBox.SelectedIndex == 0)
            {
                if (randomBotSelection.NumBotsSelected() == 0)
                {
                    return false;
                }
            }
            else
            {
                if (specificBotSelection.NumBotsSelected() == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Hides the controls of the alternate option on the same page. Example: can be used
        /// to hide the random bot controls when the user has chosen to select specific bots
        /// </summary>
        /// <param name="alternateOptionControls"></param>
        /// <param name="hostPage"></param>
        void HideAlternateOptionControls(Control[] alternateOptionControls, TabPage hostPage)
        {
            if (alternateOptionControls != null)
            {
                foreach (Control c in alternateOptionControls)
                {
                    hostPage.Controls.Remove(c);
                }
            }
        }

        /// <summary>
        /// Populates the model combo box
        /// </summary>
        void ClearAndPopulatePlayerModelsCombo()
        {
            string[] modelDirectories = Directory.GetDirectories(Quake2Paths.Player);
            availableModels.Clear();

            foreach (string dirName in modelDirectories)
            {
                if (DirectoryContainsValidModel(dirName) &&
                    DirectoryContainsValidSkins(dirName))
                {
                    string modelName = GetModelNameFromDirectoryPath(dirName);
                    string[] modelSkins = GetModelSkinsFromDirectory(dirName);

                    if (modelName != null && modelSkins != null)
                    {
                        Model validModel = new Model(modelName, modelSkins);
                        availableModels.Add(validModel);
                    }
                }
            }

            modelComboBox.Items.Clear();

            foreach (Model model in availableModels)
            {
                modelComboBox.Items.Add(model.Name);
            }

            if (modelComboBox.Items.Count > 0)
            {
                modelComboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Checks to see if the specified directory contains Quake II skins. A skin
        /// is defined as being a .pcx image that
        ///  a) is not called weapon.pcx
        ///  b) does not end in *_i.pcx
        /// </summary>
        /// <param name="dirName">Absolute path of the directory containing the skins</param>
        /// <returns>true if the folder contains valid skins, else false</returns>
        private bool DirectoryContainsValidSkins(string dirName)
        {
            string[] directoryContents = Directory.GetFiles(dirName);
            if (directoryContents == null)
            {
                return false;
            }

            foreach (string file in directoryContents)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Extension.ToLower() == ".pcx")
                {
                    string lowerCaseFileName = fileInfo.Name.ToLower();
                    if (lowerCaseFileName != "weapon.pcx" ||
                        !lowerCaseFileName.Contains("_i.pcx"))
                    {
                        // not the weapon skin, nor an icon for a skin so assume its valid
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks to see if the specified directory contains a valid Quake II model
        /// </summary>
        /// <param name="dirName">Absolute path to the directory containing
        /// the model</param>
        /// <returns>true if the directory contains a model, else false</returns>
        private bool DirectoryContainsValidModel(string dirName)
        {
            string[] files = Directory.GetFiles(dirName);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Name.ToLower() == "tris.md2")
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns the name of the model by stripping the models directory
        /// name from its absolute path. 
        /// </summary>
        /// <param name="dirPath">absolute path of the directory containing
        /// the model</param>
        /// <returns>string containing the name of the model</returns>
        private string GetModelNameFromDirectoryPath(string dirPath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);

            return dirInfo.Name;
        }

        /// <summary>
        /// Retrieves all the skins located in the specified directory. 
        /// </summary>
        /// <param name="dirName">Directory containing the model and skins</param>
        /// <returns>string array containing filenames of the skins</returns>
        private string[] GetModelSkinsFromDirectory(string dirName)
        {
            string[] directoryContents = Directory.GetFiles(dirName);
            List<string> validSkins = new List<string>();

            if (directoryContents == null)
            {
                return null;
            }

            foreach (string file in directoryContents)
            {
                FileInfo fileInfo = new FileInfo(file);

                if (fileInfo.Extension.ToLower() == ".pcx")
                {
                    string lowerCaseFileName = fileInfo.Name.ToLower();

                    if (!IsWeaponSkin(lowerCaseFileName) && !lowerCaseFileName.Contains(".pcx.pcx") &&
                        !lowerCaseFileName.Contains("_i.pcx"))
                    {
                        // not the weapon skin, nor an icon for a skin so assume its valid

                        // skinName is the name of the skin, minus the file extension.
                        // the file extension has be to removed for when it's passed as a 
                        // command line argument
                        string skinName = fileInfo.Name.Substring(0, fileInfo.Name.Length - 4);
                        validSkins.Add(skinName);
                    }
                }
            }

            // if there are no skins, I don't want a 0 sized array; I prefer just returning null
            if (validSkins.Count == 0)
            {
                return null;
            }

            return validSkins.ToArray();
        }

        /// <summary>
        /// Returns true if the specified skin is a weapon skin, else returns false.
        /// </summary>
        bool IsWeaponSkin(string skinName)
        {
            if (skinName == "w_blaster.pcx"     ||
               skinName == "w_chaingun.pcx"     ||
               skinName == "w_glauncher.pcx"    ||
               skinName == "w_grapple.pcx"      ||
               skinName == "w_hyperblaster.pcx" ||
               skinName == "w_machinegun.pcx"   ||
               skinName == "w_railgun.pcx"      ||
               skinName == "w_rlauncher.pcx"    ||
               skinName == "w_shotgun.pcx"      ||
               skinName == "w_sshotgun.pcx"     ||
               skinName == "w_bfg.pcx"          ||
               skinName == "weapon.pcx")
            {
                return true;
            }

            return false;
         }
        /// <summary>
        /// Generates the command line arguments related to player
        /// model, skin, crosshair and name
        /// </summary>
        /// <returns>string containing command line arguments related to
        /// player information
        /// </returns>
        private string GeneratePlayerArgs()
        {
            StringBuilder playerArgs = new StringBuilder();

            if (nameTextBox.Text != null)
            {
                playerArgs.AppendFormat("+set name \"{0}\" ", nameTextBox.Text);
            }
            // crosshair
            playerArgs.AppendFormat("+set crosshair {0} ",
                crosshairComboBox.SelectedIndex);

            playerArgs.AppendFormat("+set hand {0} ",
                handinessComboBox.SelectedIndex);

            string model = modelComboBox.SelectedItem as string;
            string skin = skinComboBox.SelectedItem as string;

            string modelSkinCmdFormattedString = model + "/" + skin;
            playerArgs.AppendFormat("+set skin {0} ", modelSkinCmdFormattedString);

            return playerArgs.ToString();
        }

        internal void InitIrrlicht()
        {
            try
            {
                modelViewer = new MD2Viewer(modelPictureBox);
            }
            catch (Exception e)
            {
                string errMsg = Resource.IrrlichtInitializationErrorMsg +
                    Environment.NewLine +
                    "Reason: " + e.Message +
                    Environment.NewLine +
                    "Stack Trace: " + e.StackTrace;


                MessageBox.Show(
                    errMsg,
                    Resource.Error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                disableMD2Viewer = true;
            }
        }
        /// <summary>
        /// As the name suggests, where all the initialisation happens. 
        /// </summary>
        internal void InitGUI()
        {
            try
            {
                matchSettingsTabIndex = GetTabIndex(Resource.MatchSettingsTabText);
                botsTabIndex = GetTabIndex(Resource.BotsTabText);
                teamsTabIndex = GetTabIndex(Resource.TeamTabText);
                playerTabIndex = GetTabIndex(Resource.PlayerTabText);

                // The team tab isn't supposed to be visible initially and
                // we've taken note of where it's supposed to go when it's needed,
                // so move it off to one side. 
                tabBufferForm.AddTab(tabControl.TabPages[teamsTabIndex]);

                //botSelectionComboBox.SelectedIndex = 0;
                //matchTypeComboBox.SelectedIndex = 0;
                crosshairComboBox.SelectedIndex = 1;
                handinessComboBox.SelectedIndex = 0;

                timer1.Enabled = true;

            }
            catch (Exception e)
            {
                string errorMessage = String.Format("Failed to initialise EBF: {0}\n\n{1}", e.Message, e.StackTrace);
                MessageBox.Show(
                    errorMessage,
                    Resource.EBFInitErrorTitle, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );

                Quake2Paths.Root = String.Empty;
                EraserPaths.Base = String.Empty;
            }
            
        }

        public void UpdateGUIWithGameData()
        {
            try
            {
                BotFile bf = new BotFile();

                botFileContents = bf.ParseFile(EraserPaths.BotsCfg);
                if (botFileContents.Bots.Count == 0)
                {
                    MessageBox.Show(
                        Resource.BotsFileEmpty,
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );
                }
                else
                {
                    specificBotSelection.ClearAndPopulateListView(botFileContents.Bots.ToArray());
                    ClearAndPopulateTeamControls(botFileContents.Teams.ToArray());
                }

                AddCustomMaps();

                ClearAndPopulatePlayerModelsCombo();

            }
            catch (Exception e)
            {
                MessageBox.Show(
                    e.InnerException +
                    Resource.FailedtoInitEBF +
                    e.Message +
                    Resource.PathsReset +
                    e.TargetSite +
                    e.StackTrace,
                    Resource.EBFInitErrorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                Quake2Paths.Root = String.Empty;
                EraserPaths.Base = String.Empty;
            }
        }

        /// <summary>
        /// Parses the maps stored in any custom maps stored in baseq2/maps/ and 
        /// adds them to the map treeview.
        /// </summary>
        private void AddCustomMaps()
        {
            // remove any maps currently within withe tree view;
            // needed when the user decides to change the Q2 installation
            // EBF points to.
            availableMapsTreeView.Nodes[1].Nodes.Clear();

            if (Directory.Exists(Quake2Paths.BaseQ2 + "//maps//"))
            {
                string[] mapDirectoryContents = Directory.GetFiles(Quake2Paths.BaseQ2 + "//maps//");
                if (mapDirectoryContents.Length > 0)
                {
                    foreach (string map in mapDirectoryContents)
                    {
                        FileInfo mapInfo = new FileInfo(map);
                        if (mapInfo.Extension.ToLower() == ".bsp")
                        {
                            int fullstopPosition = 0;
                            string temp = mapInfo.Name;

                            for (int i = 0; i < temp.Length; i++)
                            {
                                if (temp[i] == '.')
                                {
                                    fullstopPosition = i;
                                    break;
                                }
                            }

                            availableMapsTreeView.Nodes[1].Nodes.Add(
                                temp.Substring(0, fullstopPosition)
                                );
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tabCaption"></param>
        /// <returns></returns>
        public int GetTabIndex(string tabCaption)
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                if (tabControl.TabPages[i].Text == tabCaption)
                    return i;
            }

            return -1;
        }

        public void RemoveTab(int tabIndex)
        {
            if(TabIndex < tabControl.TabPages.Count)
                tabControl.TabPages.Remove(tabControl.TabPages[tabIndex]);
        }

        private void ClearAndPopulateTeamControls(Team[] teams)
        {
            if (playerTeamComboBox.Items.Count > 0)
            {
                playerTeamComboBox.Items.Clear();
            }

            if (teamListView.Items.Count > 0)
            {
                teamListView.Items.Clear();
            }

            for (int i = 0; i < teams.Length; i++)
            {
                teamListView.AddTeam(teams[i]);
                playerTeamComboBox.Items.Add(teams[i].Name);
            }

            if (playerTeamComboBox.Items.Count > 0)
            {
                playerTeamComboBox.SelectedIndex = 0;
            }
        }
    }
}
