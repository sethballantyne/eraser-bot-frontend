namespace EraserBotFrontend
{
    partial class DMSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fragLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.viewableWeaponsCheckBox = new System.Windows.Forms.CheckBox();
            this.friendlyFireCheckBox = new System.Windows.Forms.CheckBox();
            this.allowExitCheckBox = new System.Windows.Forms.CheckBox();
            this.allowCheatsCheckBox = new System.Windows.Forms.CheckBox();
            this.spawnFarthestCheckBox = new System.Windows.Forms.CheckBox();
            this.weaponStayCheckBox = new System.Windows.Forms.CheckBox();
            this.forceRespawnCheckBox = new System.Windows.Forms.CheckBox();
            this.infiniteAmmoCheckBox = new System.Windows.Forms.CheckBox();
            this.allowArmourCheckBox = new System.Windows.Forms.CheckBox();
            this.allowHealthCheckBox = new System.Windows.Forms.CheckBox();
            this.quadDropCheckBox = new System.Windows.Forms.CheckBox();
            this.instantPowerupsCheckBox = new System.Windows.Forms.CheckBox();
            this.allowPowerupsCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fragLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimitNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fragLimitNumericUpDown);
            this.groupBox1.Controls.Add(this.timeLimitNumericUpDown);
            this.groupBox1.Controls.Add(this.viewableWeaponsCheckBox);
            this.groupBox1.Controls.Add(this.friendlyFireCheckBox);
            this.groupBox1.Controls.Add(this.allowExitCheckBox);
            this.groupBox1.Controls.Add(this.allowCheatsCheckBox);
            this.groupBox1.Controls.Add(this.spawnFarthestCheckBox);
            this.groupBox1.Controls.Add(this.weaponStayCheckBox);
            this.groupBox1.Controls.Add(this.forceRespawnCheckBox);
            this.groupBox1.Controls.Add(this.infiniteAmmoCheckBox);
            this.groupBox1.Controls.Add(this.allowArmourCheckBox);
            this.groupBox1.Controls.Add(this.allowHealthCheckBox);
            this.groupBox1.Controls.Add(this.quadDropCheckBox);
            this.groupBox1.Controls.Add(this.instantPowerupsCheckBox);
            this.groupBox1.Controls.Add(this.allowPowerupsCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deathmatch Settings";
            // 
            // fragLimitNumericUpDown
            // 
            this.fragLimitNumericUpDown.Location = new System.Drawing.Point(239, 23);
            this.fragLimitNumericUpDown.Name = "fragLimitNumericUpDown";
            this.fragLimitNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.fragLimitNumericUpDown.TabIndex = 18;
            // 
            // timeLimitNumericUpDown
            // 
            this.timeLimitNumericUpDown.Location = new System.Drawing.Point(107, 23);
            this.timeLimitNumericUpDown.Name = "timeLimitNumericUpDown";
            this.timeLimitNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.timeLimitNumericUpDown.TabIndex = 17;
            // 
            // viewableWeaponsCheckBox
            // 
            this.viewableWeaponsCheckBox.AutoSize = true;
            this.viewableWeaponsCheckBox.Location = new System.Drawing.Point(283, 108);
            this.viewableWeaponsCheckBox.Name = "viewableWeaponsCheckBox";
            this.viewableWeaponsCheckBox.Size = new System.Drawing.Size(115, 17);
            this.viewableWeaponsCheckBox.TabIndex = 16;
            this.viewableWeaponsCheckBox.Text = "Viewable weapons";
            this.toolTip.SetToolTip(this.viewableWeaponsCheckBox, "Players can see the weapons carried by other \r\nplayers.");
            this.viewableWeaponsCheckBox.UseVisualStyleBackColor = true;
            // 
            // friendlyFireCheckBox
            // 
            this.friendlyFireCheckBox.AutoSize = true;
            this.friendlyFireCheckBox.Location = new System.Drawing.Point(283, 85);
            this.friendlyFireCheckBox.Name = "friendlyFireCheckBox";
            this.friendlyFireCheckBox.Size = new System.Drawing.Size(93, 17);
            this.friendlyFireCheckBox.TabIndex = 15;
            this.friendlyFireCheckBox.Text = "No friendly fire";
            this.friendlyFireCheckBox.UseVisualStyleBackColor = true;
            // 
            // allowExitCheckBox
            // 
            this.allowExitCheckBox.AutoSize = true;
            this.allowExitCheckBox.Location = new System.Drawing.Point(283, 62);
            this.allowExitCheckBox.Name = "allowExitCheckBox";
            this.allowExitCheckBox.Size = new System.Drawing.Size(70, 17);
            this.allowExitCheckBox.TabIndex = 14;
            this.allowExitCheckBox.Text = "Allow exit";
            this.toolTip.SetToolTip(this.allowExitCheckBox, "Players can leave the level via exits.");
            this.allowExitCheckBox.UseVisualStyleBackColor = true;
            // 
            // allowCheatsCheckBox
            // 
            this.allowCheatsCheckBox.AutoSize = true;
            this.allowCheatsCheckBox.Location = new System.Drawing.Point(153, 157);
            this.allowCheatsCheckBox.Name = "allowCheatsCheckBox";
            this.allowCheatsCheckBox.Size = new System.Drawing.Size(86, 17);
            this.allowCheatsCheckBox.TabIndex = 13;
            this.allowCheatsCheckBox.Text = "Allow cheats";
            this.toolTip.SetToolTip(this.allowCheatsCheckBox, "Allow players to use cheat codes.");
            this.allowCheatsCheckBox.UseVisualStyleBackColor = true;
            // 
            // spawnFarthestCheckBox
            // 
            this.spawnFarthestCheckBox.AutoSize = true;
            this.spawnFarthestCheckBox.Location = new System.Drawing.Point(153, 134);
            this.spawnFarthestCheckBox.Name = "spawnFarthestCheckBox";
            this.spawnFarthestCheckBox.Size = new System.Drawing.Size(97, 17);
            this.spawnFarthestCheckBox.TabIndex = 12;
            this.spawnFarthestCheckBox.Text = "Spawn farthest";
            this.spawnFarthestCheckBox.ThreeState = true;
            this.toolTip.SetToolTip(this.spawnFarthestCheckBox, "Players are spawned as far as possible from each other.");
            this.spawnFarthestCheckBox.UseVisualStyleBackColor = true;
            // 
            // weaponStayCheckBox
            // 
            this.weaponStayCheckBox.AutoSize = true;
            this.weaponStayCheckBox.Location = new System.Drawing.Point(153, 85);
            this.weaponStayCheckBox.Name = "weaponStayCheckBox";
            this.weaponStayCheckBox.Size = new System.Drawing.Size(89, 17);
            this.weaponStayCheckBox.TabIndex = 11;
            this.weaponStayCheckBox.Text = "Weapon stay";
            this.toolTip.SetToolTip(this.weaponStayCheckBox, "Weapons scattered throughout the level never disappear when picked up.");
            this.weaponStayCheckBox.UseVisualStyleBackColor = true;
            // 
            // forceRespawnCheckBox
            // 
            this.forceRespawnCheckBox.AutoSize = true;
            this.forceRespawnCheckBox.Location = new System.Drawing.Point(153, 108);
            this.forceRespawnCheckBox.Name = "forceRespawnCheckBox";
            this.forceRespawnCheckBox.Size = new System.Drawing.Size(96, 17);
            this.forceRespawnCheckBox.TabIndex = 10;
            this.forceRespawnCheckBox.Text = "Force respawn";
            this.toolTip.SetToolTip(this.forceRespawnCheckBox, "Players are forced to respawn when they die.");
            this.forceRespawnCheckBox.UseVisualStyleBackColor = true;
            // 
            // infiniteAmmoCheckBox
            // 
            this.infiniteAmmoCheckBox.AutoSize = true;
            this.infiniteAmmoCheckBox.Location = new System.Drawing.Point(153, 62);
            this.infiniteAmmoCheckBox.Name = "infiniteAmmoCheckBox";
            this.infiniteAmmoCheckBox.Size = new System.Drawing.Size(88, 17);
            this.infiniteAmmoCheckBox.TabIndex = 9;
            this.infiniteAmmoCheckBox.Text = "Infinite ammo";
            this.toolTip.SetToolTip(this.infiniteAmmoCheckBox, "Each player has unlimited ammo.");
            this.infiniteAmmoCheckBox.UseVisualStyleBackColor = true;
            // 
            // allowArmourCheckBox
            // 
            this.allowArmourCheckBox.AutoSize = true;
            this.allowArmourCheckBox.Location = new System.Drawing.Point(9, 157);
            this.allowArmourCheckBox.Name = "allowArmourCheckBox";
            this.allowArmourCheckBox.Size = new System.Drawing.Size(86, 17);
            this.allowArmourCheckBox.TabIndex = 8;
            this.allowArmourCheckBox.Text = "Allow armour";
            this.toolTip.SetToolTip(this.allowArmourCheckBox, "Players can collect armour if the level contains any.");
            this.allowArmourCheckBox.UseVisualStyleBackColor = true;
            // 
            // allowHealthCheckBox
            // 
            this.allowHealthCheckBox.AutoSize = true;
            this.allowHealthCheckBox.Location = new System.Drawing.Point(9, 134);
            this.allowHealthCheckBox.Name = "allowHealthCheckBox";
            this.allowHealthCheckBox.Size = new System.Drawing.Size(83, 17);
            this.allowHealthCheckBox.TabIndex = 7;
            this.allowHealthCheckBox.Text = "Allow health";
            this.toolTip.SetToolTip(this.allowHealthCheckBox, "Health packs will be available to players if the level contains any.");
            this.allowHealthCheckBox.UseVisualStyleBackColor = true;
            // 
            // quadDropCheckBox
            // 
            this.quadDropCheckBox.AutoSize = true;
            this.quadDropCheckBox.Location = new System.Drawing.Point(9, 108);
            this.quadDropCheckBox.Name = "quadDropCheckBox";
            this.quadDropCheckBox.Size = new System.Drawing.Size(76, 17);
            this.quadDropCheckBox.TabIndex = 6;
            this.quadDropCheckBox.Text = "Quad drop";
            this.toolTip.SetToolTip(this.quadDropCheckBox, "If a player dies and is using Quad damage, it\'ll be dropped for other players to " +
                    "pick up.");
            this.quadDropCheckBox.UseVisualStyleBackColor = true;
            // 
            // instantPowerupsCheckBox
            // 
            this.instantPowerupsCheckBox.AutoSize = true;
            this.instantPowerupsCheckBox.Location = new System.Drawing.Point(9, 85);
            this.instantPowerupsCheckBox.Name = "instantPowerupsCheckBox";
            this.instantPowerupsCheckBox.Size = new System.Drawing.Size(110, 17);
            this.instantPowerupsCheckBox.TabIndex = 5;
            this.instantPowerupsCheckBox.Text = "Instant power ups";
            this.toolTip.SetToolTip(this.instantPowerupsCheckBox, "Power ups picked up players are instantly activated.");
            this.instantPowerupsCheckBox.UseVisualStyleBackColor = true;
            // 
            // allowPowerupsCheckBox
            // 
            this.allowPowerupsCheckBox.AutoSize = true;
            this.allowPowerupsCheckBox.Location = new System.Drawing.Point(9, 62);
            this.allowPowerupsCheckBox.Name = "allowPowerupsCheckBox";
            this.allowPowerupsCheckBox.Size = new System.Drawing.Size(103, 17);
            this.allowPowerupsCheckBox.TabIndex = 4;
            this.allowPowerupsCheckBox.Text = "Allow power ups";
            this.toolTip.SetToolTip(this.allowPowerupsCheckBox, "Power ups are available to players if the level contains any.");
            this.allowPowerupsCheckBox.UseVisualStyleBackColor = true;
            this.allowPowerupsCheckBox.CheckedChanged += new System.EventHandler(this.allowPowerupsCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frag limit";
            this.toolTip.SetToolTip(this.label2, "The maximum number of kills a player can make. When the limit is reached, \r\nthe m" +
                    "atch is over and the next map loads.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time limit (minutes)";
            this.toolTip.SetToolTip(this.label1, "The amount of time in minutes each match lasts. 0 means this isn\'t used. \r\nWhen t" +
                    "he limit is reached, the next map will load. ");
            // 
            // DMSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 248);
            this.Controls.Add(this.groupBox1);
            this.Name = "DMSettings";
            this.Text = "DMSettings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fragLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimitNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox forceRespawnCheckBox;
        private System.Windows.Forms.CheckBox infiniteAmmoCheckBox;
        private System.Windows.Forms.CheckBox allowArmourCheckBox;
        private System.Windows.Forms.CheckBox allowHealthCheckBox;
        private System.Windows.Forms.CheckBox quadDropCheckBox;
        private System.Windows.Forms.CheckBox instantPowerupsCheckBox;
        private System.Windows.Forms.CheckBox allowPowerupsCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox viewableWeaponsCheckBox;
        private System.Windows.Forms.CheckBox friendlyFireCheckBox;
        private System.Windows.Forms.CheckBox allowExitCheckBox;
        private System.Windows.Forms.CheckBox allowCheatsCheckBox;
        private System.Windows.Forms.CheckBox spawnFarthestCheckBox;
        private System.Windows.Forms.CheckBox weaponStayCheckBox;
        private System.Windows.Forms.NumericUpDown fragLimitNumericUpDown;
        private System.Windows.Forms.NumericUpDown timeLimitNumericUpDown;
        protected System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip;

    }
}