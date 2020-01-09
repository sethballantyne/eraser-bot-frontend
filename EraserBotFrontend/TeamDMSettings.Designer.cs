namespace EraserBotFrontend
{
    partial class TeamDMSettings : DMSettings
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
            this.teamsbyModelCheckBox = new System.Windows.Forms.CheckBox();
            this.teamsbySkinCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teamsbyModelCheckBox);
            this.groupBox1.Controls.Add(this.teamsbySkinCheckBox);
            this.groupBox1.Controls.SetChildIndex(this.teamsbySkinCheckBox, 0);
            this.groupBox1.Controls.SetChildIndex(this.teamsbyModelCheckBox, 0);
            // 
            // teamsbyModelCheckBox
            // 
            this.teamsbyModelCheckBox.AutoSize = true;
            this.teamsbyModelCheckBox.Location = new System.Drawing.Point(283, 131);
            this.teamsbyModelCheckBox.Name = "teamsbyModelCheckBox";
            this.teamsbyModelCheckBox.Size = new System.Drawing.Size(103, 17);
            this.teamsbyModelCheckBox.TabIndex = 19;
            this.teamsbyModelCheckBox.Text = "Teams by model";
            this.toolTip.SetToolTip(this.teamsbyModelCheckBox, "Players are grouped into teams based on their model.\r\n");
            this.teamsbyModelCheckBox.UseVisualStyleBackColor = true;
            // 
            // teamsbySkinCheckBox
            // 
            this.teamsbySkinCheckBox.AutoSize = true;
            this.teamsbySkinCheckBox.Location = new System.Drawing.Point(283, 157);
            this.teamsbySkinCheckBox.Name = "teamsbySkinCheckBox";
            this.teamsbySkinCheckBox.Size = new System.Drawing.Size(94, 17);
            this.teamsbySkinCheckBox.TabIndex = 20;
            this.teamsbySkinCheckBox.Text = "Teams by skin";
            this.toolTip.SetToolTip(this.teamsbySkinCheckBox, "Players are grouped into teams based on their skin.");
            this.teamsbySkinCheckBox.UseVisualStyleBackColor = true;
            // 
            // TeamDMSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 248);
            this.Name = "TeamDMSettings";
            this.Text = "TeamDMSettings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox teamsbyModelCheckBox;
        private System.Windows.Forms.CheckBox teamsbySkinCheckBox;
        private System.Windows.Forms.ToolTip toolTip;

    }
}