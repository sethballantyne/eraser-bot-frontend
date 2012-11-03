/*
*Copyright (c) 2011 Seth Ballantyne
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
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;

namespace EraserBotFrontend
{
    /// <summary>
    /// Custom ListView control. Makes manipulating the information 
    /// being displayed a bit easier (supposedly)
    /// </summary>
    public partial class TeamListView : ListView
    {
        public TeamListView()
        {
            this.Columns.Add("nameColumn", "Name", 120);
            this.Columns.Add("abbreviationColumn", "Abbreviation", 40);
            this.Columns.Add("modelColumn", "Model", 40);
            this.Columns.Add("skinColumn", "Skin", 40);
            this.Columns.Add("membersColumn", "Members", 180);
            
            this.View = View.Details;
            this.CheckBoxes = true;
            this.GridLines = true;

            InitializeComponent();
        }

        /// <summary>
        /// Adds a team to the list
        /// </summary>
        /// <param name="team">the desired team to be added</param>
        public void AddTeam(Team team)
        {
            string[] items = new string[5];
            string[] buffer;
            StringBuilder formattedString = new StringBuilder();

            buffer = SplitModelSkin(team.SkinAndModel);

            items[0] = team.Name;
            items[1] = team.Abbreviation;
            items[2] = buffer[0];   // team model
            items[3] = buffer[1];   // team skin
        
            foreach (string str in team.Members)
            {
                formattedString.Append(str + " ");
            }

            items[4] = formattedString.ToString();

            ListViewItem lvi = new ListViewItem(items);
            this.Items.Add(lvi);
        }

        /// <summary>
        /// Groups all the checked teams in the list into an array.
        /// </summary>
        /// <returns>An array of Team containing each checked team</returns>
        public Team[] CheckedTeams()
        {
            List<Team> teamList = new List<Team>();

            foreach (ListViewItem item in this.CheckedItems)
            {
                //List<string> members = new List<string>();

                string name = item.SubItems[0].Text;
                string abbreviation = item.SubItems[1].Text;
                string skinModel = item.SubItems[2].Text + "/" + item.SubItems[3].Text;
                string[] members = item.SubItems[4].Text.Split(new char[] { ' ' }); 

                Team team = new Team(name, abbreviation,
                    skinModel, members);

                 teamList.Add(team);
            }

           
                return teamList.ToArray();
        }

        /// <summary>
        /// Splits the formatted string containing the teams model and skin into two seperate
        /// strings
        /// </summary>
        /// <param name="modelSkin">the formatted string containing the model and skin</param>
        /// <returns>A string array containing the two split strings. The first element
        /// will contain the model, the second the skin. The skin element will be null
        /// if no skin was specified. If no model was specified, both elements will be null.</returns>
        private string[] SplitModelSkin(string modelSkin)
        {
            char[] seperatingCharacters = new char[] { '/', '\\' };
            string[] buffer = new string[2] { null, null };
            string[] splitStrings;

            splitStrings = modelSkin.Split(seperatingCharacters);
            for (int i = 0; i < splitStrings.Length; i++)
            {
                if (i == 2)
                    break;

                buffer[i] = splitStrings[i];
            }

            return buffer;
        }
    }
}
