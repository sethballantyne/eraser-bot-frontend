namespace EraserBotFrontend
{
    partial class SpecificBotSelection
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
            this.botSelectionCounterLabel = new System.Windows.Forms.Label();
            this.advancedOptionsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.specificBotsListView = new EraserBotFrontend.BotListView();
            this.botParseProgressBar = new System.Windows.Forms.ProgressBar();
            this.selectedBotCountLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skillLabel
            // 
            this.skillLabel.Location = new System.Drawing.Point(12, 235);
            // 
            // skillComboBox
            // 
            this.skillComboBox.Location = new System.Drawing.Point(44, 232);
            // 
            // botSelectionCounterLabel
            // 
            this.botSelectionCounterLabel.AutoSize = true;
            this.botSelectionCounterLabel.Location = new System.Drawing.Point(12, 162);
            this.botSelectionCounterLabel.Name = "botSelectionCounterLabel";
            this.botSelectionCounterLabel.Size = new System.Drawing.Size(0, 13);
            this.botSelectionCounterLabel.TabIndex = 2;
            // 
            // advancedOptionsButton
            // 
            this.advancedOptionsButton.Location = new System.Drawing.Point(12, 197);
            this.advancedOptionsButton.Name = "advancedOptionsButton";
            this.advancedOptionsButton.Size = new System.Drawing.Size(89, 23);
            this.advancedOptionsButton.TabIndex = 1;
            this.advancedOptionsButton.Text = "&Adv. Options";
            this.advancedOptionsButton.UseVisualStyleBackColor = true;
            this.advancedOptionsButton.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.specificBotsListView);
            this.groupBox1.Controls.Add(this.advancedOptionsButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Specific Bots";
            // 
            // specificBotsListView
            // 
            this.specificBotsListView.CheckBoxes = true;
            this.specificBotsListView.GridLines = true;
            this.specificBotsListView.Location = new System.Drawing.Point(6, 19);
            this.specificBotsListView.Name = "specificBotsListView";
            this.specificBotsListView.Size = new System.Drawing.Size(420, 151);
            this.specificBotsListView.TabIndex = 2;
            this.specificBotsListView.UseCompatibleStateImageBehavior = false;
            this.specificBotsListView.View = System.Windows.Forms.View.Details;
            this.specificBotsListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.specificBotsListView_ItemChecked);
            this.specificBotsListView.SelectedIndexChanged += new System.EventHandler(this.specificBotsListView_SelectedIndexChanged);
            this.specificBotsListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.specificBotsListView_ColumnClick);
            // 
            // botParseProgressBar
            // 
            this.botParseProgressBar.Location = new System.Drawing.Point(215, 232);
            this.botParseProgressBar.Name = "botParseProgressBar";
            this.botParseProgressBar.Size = new System.Drawing.Size(232, 23);
            this.botParseProgressBar.TabIndex = 10;
            this.botParseProgressBar.Visible = false;
            // 
            // selectedBotCountLabel
            // 
            this.selectedBotCountLabel.AutoSize = true;
            this.selectedBotCountLabel.Location = new System.Drawing.Point(370, 235);
            this.selectedBotCountLabel.Name = "selectedBotCountLabel";
            this.selectedBotCountLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedBotCountLabel.TabIndex = 9;
            // 
            // SpecificBotSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 275);
            this.Controls.Add(this.botParseProgressBar);
            this.Controls.Add(this.selectedBotCountLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botSelectionCounterLabel);
            this.Name = "SpecificBotSelection";
            this.Text = "BotSelection";
            this.Load += new System.EventHandler(this.SpecificBotSelection_Load);
            this.Controls.SetChildIndex(this.botSelectionCounterLabel, 0);
            this.Controls.SetChildIndex(this.skillComboBox, 0);
            this.Controls.SetChildIndex(this.skillLabel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.selectedBotCountLabel, 0);
            this.Controls.SetChildIndex(this.botParseProgressBar, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label botSelectionCounterLabel;
        private System.Windows.Forms.Button advancedOptionsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label selectedBotCountLabel;
        private System.Windows.Forms.ProgressBar botParseProgressBar;
        private BotListView specificBotsListView;
        private System.Windows.Forms.ToolTip toolTip;

    }
}