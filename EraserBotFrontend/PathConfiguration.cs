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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EraserBotFrontend.Paths;

namespace EraserBotFrontend
{
    /// <summary>
    /// Used for configuring the paths required by the application
    /// </summary>
    public partial class PathConfiguration : Form
    {
        // Calling form
        MainForm mainForm;

        public PathConfiguration()
        {
            InitializeComponent();
        }

        public PathConfiguration(MainForm mainForm) : this()
        {
            this.mainForm = mainForm;
        }

        private void q2PathBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (DirContainsValidQuake2Installation(folderBrowserDialog.SelectedPath))
                {
                    q2PathTextBox.Text = folderBrowserDialog.SelectedPath;

                    if (eraserPathTextBox.Text != String.Empty)
                    {
                        applyButton.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show(Resource.InvalidQuake2Installation, "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //q2PathTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void eraserBotBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (DirContainsValidEraserInstallation(folderBrowserDialog.SelectedPath))
                {
                    eraserPathTextBox.Text = folderBrowserDialog.SelectedPath;

                    if (q2PathTextBox.Text != String.Empty)
                    {
                        applyButton.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show(Resource.InvalidEraserInstallation, "", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (mainForm.WindowState == FormWindowState.Minimized)
                mainForm.WindowState = FormWindowState.Normal;

            Hide();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            ApplyChanges();
        }

        private void PathConfiguration_Shown(object sender, EventArgs e)
        {
            //try
            //{
                q2PathTextBox.Text = Quake2Paths.Root;
                eraserPathTextBox.Text = EraserPaths.Base;
            //}
            //catch (System.Configuration.ConfigurationException)
            //{
            //    MessageBox.Show(Resource.EN_ConfigurationFileError, "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        ///// <summary>
        ///// Clears the paths, returning them to their initial (empty) state 
        ///// </summary>
        //internal void Reset()
        //{
        //    q2PathTextBox.Text = String.Empty;
        //    eraserPathTextBox.Text = String.Empty;

        //    applyButton.Enabled = false;
        //}

        /// <summary>
        /// Checks to see if a "valid" installation is present at the specified path.
        /// Valid is defined as all files that EBF needs to function being present.
        /// </summary>
        /// <param name="path">selected path to the be checked</param>
        /// <returns>false if valid, else true</returns>
        private bool DirContainsValidQuake2Installation(string path)
        {
            if (Directory.Exists(path + "//baseq2"))
            {
                if (Directory.Exists(path + "//baseq2//players"))
                {
                    if (File.Exists(path + "//quake2.exe") &&
                       File.Exists(path + "//baseq2//gamex86.dll"))
                    {
                        return true;
                    }
                }
                
            }

            return false;
        }

        /// <summary>
        /// Checks to see if the specified directory contains what appears to be a
        /// valid installation of Eraser bot.
        /// </summary>
        /// <param name="p">absolute path to the directory containing the installation</param>
        /// <returns>true if it appears to contain a valid installation, otherwise
        /// false</returns>
        private bool DirContainsValidEraserInstallation(string path)
        {
            // TODO: this is missing the glaringly obvious, namelty checking the 
            // name of the directory the DLL is kept in. 
            if (File.Exists(path + "//gamex86.dll"))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Updates the stored paths with the values located in the respective text boxes.
        /// </summary>
        private void ApplyChanges()
        {
            // TODO: change this so the method doesn't "know" about the text boxes.
            Quake2Paths.Root = q2PathTextBox.Text;
            EraserPaths.Base = eraserPathTextBox.Text;


            // changed the paths so reload
            mainForm.Init();

            applyButton.Enabled = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Reset();

            //applyButton.Enabled = true;
        }

    }
}
