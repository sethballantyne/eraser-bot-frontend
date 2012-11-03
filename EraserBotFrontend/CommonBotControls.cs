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
    /// Contains properties and controls required by both the RandomBotSelection and
    /// SpecificBotSelection classes.
    /// </summary>
    public partial class CommonBotControlsForm : Form
    {
        public CommonBotControlsForm()
        {
            InitializeComponent();

            skillComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Sets the Skill level of the bots in the match. Use this to create easy, moderate or
        /// difficult matches. 
        /// </summary>
        /// <remarks>Seems kinda odd to me that bots have an individual skill and then
        /// a "global" skill, but there you go.</remarks>
        public int Skill
        {
            get { return skillComboBox.SelectedIndex; }
            set { skillComboBox.SelectedIndex = value; }
        }

        public virtual int NumBotsSelected()
        {
            return 0;
        }
    }
}
