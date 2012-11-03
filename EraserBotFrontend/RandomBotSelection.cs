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
    /// RandomBotSelection allows the user to choose how many bots to generate, 
    /// but leaves the selection up to the mod. This form is only available when
    /// configuring a Deathmatch game.
    /// </summary>
    public partial class RandomBotSelection : CommonBotControlsForm
    {
        public RandomBotSelection()
        {
            //base();
            InitializeComponent();

            //int yPos = groupBox1.Location.Y + groupBox1.Size.Height + 6;
            //skillLabel.Location = new Point(26, yPos);
            //skillComboBox.Location = new Point(44, yPos);
            //skillLabel.Location.Y = 
        }

        /// <summary>
        /// Retrives the amount of bots set to be spawned when the game is launched.
        /// </summary>
        /// <returns>integer containing the number of bots to be generated</returns>
        public override int NumBotsSelected()
        {
            // TODO: change to a property.
            return Convert.ToInt32(randomBotsNumericUpDown.Value);
        }
    }
}
