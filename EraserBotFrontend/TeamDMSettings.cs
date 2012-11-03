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
    /// Allows for the configuration of Team Deathmatch matches. Like DMSettings,
    /// most of the options revolve around the DMFlags variable
    /// </summary>
    public partial class TeamDMSettings : DMSettings
    {
        public TeamDMSettings() : base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates the value of DMFlags, based on the options selected by the user
        /// </summary>
        /// <returns></returns>
        public string GenerateTeamDMArgs()
        {

            // TODO: DMFlags is being set twice: in GenerateDeathmatchArgs()
            // and then again, where we're calculating the 
            // TeamDM flags. Probably better to clean it up
            // so it's only called once when doing the team stuff.
            // Change the name of the method as well.

            StringBuilder args = new StringBuilder();
            int flags = base.GenerateDMFlags();

            args.Append(base.GenerateDeathmatchArgs());

            if (teamsbyModelCheckBox.Checked)
            {
                flags |= (int) DMFlags.TeamsByModel;
            }
            if (teamsbySkinCheckBox.Checked)
            {
                flags |= (int) DMFlags.TeamsBySkin;
            }

            args.AppendFormat("+set dmflags {0} ", flags);

            return args.ToString();
        }
    }
}
