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

namespace EraserBotFrontend
{
    /// <summary>
    /// Allows the user to select a specific bot, instead of randomly generating them
    /// as is the case with RandomBotSelection. This form is only visible when the user
    /// is configuring a Deathmatch game.
    /// </summary>
    public partial class SpecificBotSelection : CommonBotControlsForm
    {
        public SpecificBotSelection()
        {
            InitializeComponent();
        }

        private void SpecificBotSelection_Load(object sender, EventArgs e)
        {
            // checking .Count simply for safety's sake.
            //if(skillComboBox.Items.Count > 0)
            //    skillComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Adds the specified bots to the list view. 
        /// If bots already exist in the list view, it'll be cleared before
        /// they're added. 
        /// </summary>
        /// <param name="bots"></param>
        public void ClearAndPopulateListView(Bot[] bots)
        {
            if (specificBotsListView.Items.Count > 0)
            {
                specificBotsListView.Items.Clear();
            }

            foreach (Bot b in bots)
            {
                specificBotsListView.AddBot(b);
            }
        }

        /// <summary>
        /// Returns a formatted string containing the names of any checked bots.
        /// Used when generating the sv_bots command line argument
        /// </summary>
        public string SelectedBots
        {
            get
            {
                StringBuilder selectedBotNames = new StringBuilder();
                Bot[] checkedBots = this.specificBotsListView.CheckedBots();

                for (int i = 0; i < checkedBots.Length; i++)
                {
                    selectedBotNames.Append(checkedBots[i].Name + " ");
                }
                //        
                //    }
                //}

                return selectedBotNames.ToString();
            }
        }

        public override int NumBotsSelected()
        {
            return specificBotsListView.CheckedItems.Count;
        }

        private void specificBotsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //StringBuilder labelText = new StringBuilder();
            //labelText.AppendFormat("{0} bots selected", 
            //    specificBotsListView.SelectedItems.Count);

            //selectedBotCountLabel.Text = labelText.ToString();
        }

        private void specificBotsListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            StringBuilder labelText = new StringBuilder();
            int numCheckedItems = specificBotsListView.CheckedItems.Count;
            string bot;

            // bloody perfectionists ;)
            if (numCheckedItems == 1)
                bot = "bot";
            else
                bot = "bots";

            labelText.AppendFormat("{0} {1} selected", numCheckedItems, bot);
            selectedBotCountLabel.Text = labelText.ToString();
        }

        private void specificBotsListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            specificBotsListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }
    }
}
