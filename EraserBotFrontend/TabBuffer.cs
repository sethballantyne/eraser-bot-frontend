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
    /// Holds tabs that are not currently being shown (ie, deathmatch tab when configuring
    /// a Team Deathmatch game and vice versa).
    /// </summary>
    public partial class TabBuffer : Form
    {
        public TabBuffer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a tab to the buffer
        /// </summary>
        /// <param name="tabPage">Tab to be added</param>
        internal void AddTab(TabPage tabPage)
        {
            tabControl1.TabPages.Add(tabPage);
        }

        /// <summary>
        /// Retrieves a tab from the buffer by caption
        /// </summary>
        /// <param name="tabPage">the caption of the desired buffer</param>
        /// <returns>the desired tab if it exists, else null</returns>
        internal TabPage GetTab(string tabPage)
        {
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                if (tabControl1.TabPages[i].Text == tabPage)
                {
                    TabPage desiredTab = tabControl1.TabPages[i];
                    tabControl1.TabPages.Remove(tabControl1.TabPages[i]);

                    return desiredTab;
                    
                }
            }

            return null;
        }
    }
}
