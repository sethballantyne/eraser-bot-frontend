namespace EraserBotFrontend
{
    partial class CommonBotControlsForm
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
            this.skillLabel = new System.Windows.Forms.Label();
            this.skillComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // skillLabel
            // 
            this.skillLabel.AutoSize = true;
            this.skillLabel.Location = new System.Drawing.Point(23, 207);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(26, 13);
            this.skillLabel.TabIndex = 7;
            this.skillLabel.Text = "Skill";
            this.toolTip.SetToolTip(this.skillLabel, "The skill level of the bots.");
            // 
            // skillComboBox
            // 
            this.skillComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillComboBox.FormattingEnabled = true;
            this.skillComboBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Very Hard"});
            this.skillComboBox.Location = new System.Drawing.Point(55, 204);
            this.skillComboBox.Name = "skillComboBox";
            this.skillComboBox.Size = new System.Drawing.Size(89, 21);
            this.skillComboBox.TabIndex = 8;
            this.toolTip.SetToolTip(this.skillComboBox, "The skill level of the bots.");
            // 
            // CommonBotControlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 237);
            this.Controls.Add(this.skillComboBox);
            this.Controls.Add(this.skillLabel);
            this.Name = "CommonBotControlsForm";
            this.Text = "CommonBotControls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label skillLabel;
        protected System.Windows.Forms.ComboBox skillComboBox;
        private System.Windows.Forms.ToolTip toolTip;

    }
}