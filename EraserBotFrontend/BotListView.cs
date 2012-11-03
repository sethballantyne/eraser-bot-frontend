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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EraserBotFrontend
{
    /// <summary>
    /// A customized listview control designed to make displaying bot information a bit easier
    /// </summary>
    public partial class BotListView : ListView
    {
        /// <summary>
        /// Default Constructor. Sets up the columns and other ground work.
        /// </summary>
        public BotListView()
        {
            // TODO: Remove hardcoded strings
            this.Columns.Add("nameColumn", "Name", 60);
            this.Columns.Add("modelColumn", "Model", 60);
            this.Columns.Add("skinColumn", "Skin", 60);
            this.Columns.Add("AccuracyColumn", "Accuracy", 60);
            this.Columns.Add("AggressivenessColumn", "Aggressiveness", 60);
            this.Columns.Add("combatSkillColumn", "Combat Skill", 60);
            this.Columns.Add("favouriteWeaponColumn", "Favourite Weapon", 60);
            this.Columns.Add("quadFreakColumn", "Quad Freak", 60);
            this.Columns.Add("camperColumn", "Camper", 60);
            this.Columns.Add("averagePing", "Average Ping", 60);

            this.View = View.Details;
            this.CheckBoxes = true;

            InitializeComponent();
        }

        /// <summary>
        /// Adds a bot to the control
        /// </summary>
        /// <param name="bot">the instance of Bot to add</param>
        public void AddBot(Bot bot)
        {
            string[] items = new string[10];
            char[] modelSkinSeperator = new char[] { '/' };

            //foreach (Bot b in bots)
            //{
                string[] modelAndSkin = bot.ModelAndSkin.Split(modelSkinSeperator);
                items[0] = bot.Name;

                // if two substrings dont result from the split operation,
                // falling back to the original string is probably the best bet.
                if (modelAndSkin.Length == 2)
                {
                    items[1] = modelAndSkin[0];
                    items[2] = modelAndSkin[1];
                }
                else
                {
                    items[1] = bot.ModelAndSkin;
                    items[2] = bot.ModelAndSkin;
                }

                items[3] = bot.FiringAccuracy.ToString();
                items[4] = bot.Aggressiveness.ToString();
                items[5] = bot.CombatSkills.ToString();
                items[6] = bot.FavouredWeapon.ToString();
                items[7] = bot.IsQuadFreak.ToString();
                items[8] = bot.IsCamper.ToString();
                items[9] = bot.Ping.ToString();

                ListViewItem lvi = new ListViewItem(items);
                this.Items.Add(lvi);
        }

        /// <summary>
        /// Use CheckedBots() to easily retrieve instances of any bots that are checked within
        /// the control. 
        /// </summary>
        /// <returns>If 1 or more bots are checked, an Array of type Bot will be returned
        /// containing instances of all bots checked within the control. If not bots are checked
        /// an empty array will be returned.</returns>
        public Bot[] CheckedBots()
        {
            List<Bot> botList = new List<Bot>();

            foreach (ListViewItem item in this.CheckedItems)
            {
                StringBuilder modelAndSkin = new StringBuilder(
                    item.SubItems[1].Text + "/" + item.SubItems[2].Text
                    );

                uint accuracy = uint.Parse(item.SubItems[3].Text);
                uint aggressiveness = uint.Parse(item.SubItems[4].Text);
                uint combat = uint.Parse(item.SubItems[5].Text);

                FavouriteWeapon weapon = (FavouriteWeapon) Enum.Parse(typeof(FavouriteWeapon), 
                    item.SubItems[6].Text, true);

                bool quadFreak = Boolean.Parse(item.SubItems[7].Text);
                bool camper = Boolean.Parse(item.SubItems[8].Text);
                uint averagePing = uint.Parse(item.SubItems[9].Text);

                Bot checkedBot = new Bot(
                    item.SubItems[0].Text,  // Name
                    modelAndSkin.ToString(),  
                    accuracy,  
                    aggressiveness,  
                    combat,  // combat skill
                    weapon,                 // favourite weapon
                    quadFreak, 
                    camper,
                    averagePing
                    );

                botList.Add(checkedBot);
            }

            return botList.ToArray();
        }
    }
}
