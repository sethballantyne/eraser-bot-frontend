namespace EraserBotFrontend
{
    partial class RandomBotSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.randomBotsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randomBotsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // skillLabel
            // 
            this.skillLabel.Location = new System.Drawing.Point(18, 112);
            this.toolTip.SetToolTip(this.skillLabel, "The skill level of the bots.");
            // 
            // skillComboBox
            // 
            this.skillComboBox.Location = new System.Drawing.Point(50, 109);
            this.toolTip.SetToolTip(this.skillComboBox, "The number of bots taking part in the match.");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.randomBotsNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Random Bots";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of bots ";
            this.toolTip.SetToolTip(this.label1, "The number of bots taking part in the match.");
            // 
            // randomBotsNumericUpDown
            // 
            this.randomBotsNumericUpDown.Location = new System.Drawing.Point(94, 19);
            this.randomBotsNumericUpDown.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.randomBotsNumericUpDown.Name = "randomBotsNumericUpDown";
            this.randomBotsNumericUpDown.Size = new System.Drawing.Size(53, 20);
            this.randomBotsNumericUpDown.TabIndex = 0;
            this.toolTip.SetToolTip(this.randomBotsNumericUpDown, "The number of bots taking part in the match.");
            // 
            // RandomBotSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "RandomBotSelection";
            this.Text = "RandomBots";
            this.Controls.SetChildIndex(this.skillComboBox, 0);
            this.Controls.SetChildIndex(this.skillLabel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randomBotsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown randomBotsNumericUpDown;
        private System.Windows.Forms.ToolTip toolTip;
    }
}