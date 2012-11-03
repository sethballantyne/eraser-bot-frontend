namespace EraserBotFrontend
{
    partial class PathConfiguration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.q2PathTextBox = new System.Windows.Forms.TextBox();
            this.eraserPathTextBox = new System.Windows.Forms.TextBox();
            this.q2PathBrowseButton = new System.Windows.Forms.Button();
            this.eraserBotBrowseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.applyButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quake II path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Eraser Bot path";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // q2PathTextBox
            // 
            this.q2PathTextBox.Location = new System.Drawing.Point(86, 20);
            this.q2PathTextBox.Name = "q2PathTextBox";
            this.q2PathTextBox.ReadOnly = true;
            this.q2PathTextBox.Size = new System.Drawing.Size(213, 20);
            this.q2PathTextBox.TabIndex = 0;
            // 
            // eraserPathTextBox
            // 
            this.eraserPathTextBox.Location = new System.Drawing.Point(86, 60);
            this.eraserPathTextBox.Name = "eraserPathTextBox";
            this.eraserPathTextBox.ReadOnly = true;
            this.eraserPathTextBox.Size = new System.Drawing.Size(213, 20);
            this.eraserPathTextBox.TabIndex = 2;
            // 
            // q2PathBrowseButton
            // 
            this.q2PathBrowseButton.Location = new System.Drawing.Point(305, 17);
            this.q2PathBrowseButton.Name = "q2PathBrowseButton";
            this.q2PathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.q2PathBrowseButton.TabIndex = 1;
            this.q2PathBrowseButton.Text = "&Browse";
            this.q2PathBrowseButton.UseVisualStyleBackColor = true;
            this.q2PathBrowseButton.Click += new System.EventHandler(this.q2PathBrowseButton_Click);
            // 
            // eraserBotBrowseButton
            // 
            this.eraserBotBrowseButton.Location = new System.Drawing.Point(305, 57);
            this.eraserBotBrowseButton.Name = "eraserBotBrowseButton";
            this.eraserBotBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.eraserBotBrowseButton.TabIndex = 3;
            this.eraserBotBrowseButton.Text = "&Browse";
            this.eraserBotBrowseButton.UseVisualStyleBackColor = true;
            this.eraserBotBrowseButton.Click += new System.EventHandler(this.eraserBotBrowseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(328, 124);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.q2PathTextBox);
            this.groupBox1.Controls.Add(this.eraserBotBrowseButton);
            this.groupBox1.Controls.Add(this.q2PathBrowseButton);
            this.groupBox1.Controls.Add(this.eraserPathTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 98);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Required Paths";
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(247, 124);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 8;
            this.applyButton.Text = "&Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 124);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // PathConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 159);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PathConfiguration";
            this.ShowInTaskbar = false;
            this.Text = "Configure Paths";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.PathConfiguration_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox q2PathTextBox;
        private System.Windows.Forms.TextBox eraserPathTextBox;
        private System.Windows.Forms.Button q2PathBrowseButton;
        private System.Windows.Forms.Button eraserBotBrowseButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button resetButton;
    }
}