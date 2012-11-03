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
    /// Used for configuring Deathmatch related settings, mainly revolving 
    /// around the Quake II DMFlags variable
    /// </summary>
    public partial class DMSettings : Form
    {
        public DMSettings()
        {
            InitializeComponent();
        }

        private void allowPowerupsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            instantPowerupsCheckBox.Enabled = allowPowerupsCheckBox.Checked;
            if (!instantPowerupsCheckBox.Enabled)
                instantPowerupsCheckBox.Checked = false;
            else
                // enable the option by default
                instantPowerupsCheckBox.Checked = true;
        }

        /// <summary>
        /// Generates the deathmatch-specific command line arguments based on the
        /// options selected by the user
        /// </summary>
        /// <returns>A string containing the deathmatch-related 
        /// command line arguments</returns>
        public string GenerateDeathmatchArgs()
        {
            StringBuilder dmArgs = new StringBuilder("+set deathmatch 1 ");

            if (timeLimitNumericUpDown.Value > 0)
            {
                dmArgs.AppendFormat("+set timelimit {0} ",
                    timeLimitNumericUpDown.Value);
            }

            if (fragLimitNumericUpDown.Value > 0)
            {
                dmArgs.AppendFormat("+set fraglimit {0} ", 
                    fragLimitNumericUpDown.Value);
            }

            if (allowCheatsCheckBox.Checked)
            {
                dmArgs.Append("+set cheats 1 ");
            }

            if (viewableWeaponsCheckBox.Checked)
            {
                dmArgs.Append("+set view_weapons 1 ");
            }

            dmArgs.AppendFormat("+set dmflags {0} ", GenerateDMFlags());
            //dmArgs.Append("+map q2dm1 ");

            return dmArgs.ToString();
        }

        /// <summary>
        /// Generates the DMFlags variable based on the selections
        /// made by the user
        /// </summary>
        /// <returns>integer representing the DMFlag</returns>
        public int GenerateDMFlags()
        {
            int flags = 0;

            if (!allowPowerupsCheckBox.Checked)
            {
                flags |= (int)DMFlags.NoPowerups;
            }
            if (instantPowerupsCheckBox.Checked)
            {
                flags |= (int)DMFlags.InstantPowerups;
            }

            if (quadDropCheckBox.Checked)
            {
                flags |= (int)DMFlags.QuadDrop;
            }

            if (!allowHealthCheckBox.Checked)
            {
                flags |= (int)DMFlags.NoHealth;
            }

            if (!allowArmourCheckBox.Checked)
            {
                flags |= (int)DMFlags.NoArmour;
            }

            if (infiniteAmmoCheckBox.Checked)
            {
                flags |= (int)DMFlags.InfiniteAmmo;
            }

            if (weaponStayCheckBox.Checked)
            {
                flags |= (int)DMFlags.WeaponsStay;
            }

            if (forceRespawnCheckBox.Checked)
            {
                flags |= (int)DMFlags.ForceRespawn;
            }

            if (spawnFarthestCheckBox.Checked)
            {
                flags |= (int)DMFlags.SpawnFarthest;
            }

            if (allowExitCheckBox.Checked)
            {
                flags |= (int)DMFlags.AllowExit;
            }

            if (friendlyFireCheckBox.Checked)
            {
                flags |= (int)DMFlags.NoFriendlyFire;
            }

            return flags;
        }
    }
}
