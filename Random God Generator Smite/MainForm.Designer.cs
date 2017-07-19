namespace Random_God_Generator_Smite
{
    partial class MainForm
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
            this.godClassSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.generateRandomGodButton = new System.Windows.Forms.Button();
            this.generatedGodLabel = new System.Windows.Forms.TextBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // godClassSelectionComboBox
            // 
            this.godClassSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.godClassSelectionComboBox.FormattingEnabled = true;
            this.godClassSelectionComboBox.Items.AddRange(new object[] {
            "Any Class",
            "Mage",
            "Warrior",
            "Hunter",
            "Guardian",
            "Assassin"});
            this.godClassSelectionComboBox.Location = new System.Drawing.Point(94, 47);
            this.godClassSelectionComboBox.Name = "godClassSelectionComboBox";
            this.godClassSelectionComboBox.Size = new System.Drawing.Size(197, 21);
            this.godClassSelectionComboBox.TabIndex = 0;
            // 
            // generateRandomGodButton
            // 
            this.generateRandomGodButton.Location = new System.Drawing.Point(94, 145);
            this.generateRandomGodButton.Name = "generateRandomGodButton";
            this.generateRandomGodButton.Size = new System.Drawing.Size(197, 51);
            this.generateRandomGodButton.TabIndex = 1;
            this.generateRandomGodButton.Text = "Generate Random god";
            this.generateRandomGodButton.UseVisualStyleBackColor = true;
            this.generateRandomGodButton.Click += new System.EventHandler(this.generateRandomGodButton_Click);
            // 
            // generatedGodLabel
            // 
            this.generatedGodLabel.Enabled = false;
            this.generatedGodLabel.Location = new System.Drawing.Point(94, 21);
            this.generatedGodLabel.Name = "generatedGodLabel";
            this.generatedGodLabel.Size = new System.Drawing.Size(197, 20);
            this.generatedGodLabel.TabIndex = 4;
            this.generatedGodLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(297, 173);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(76, 23);
            this.infoButton.TabIndex = 5;
            this.infoButton.Text = "Information";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Random_God_Generator_Smite.Properties.Resources.smite_wallpaper_black_and_white_by_leepiin_d8muz3e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(385, 208);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.generatedGodLabel);
            this.Controls.Add(this.generateRandomGodButton);
            this.Controls.Add(this.godClassSelectionComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smite Random God Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox godClassSelectionComboBox;
        private System.Windows.Forms.Button generateRandomGodButton;
        private System.Windows.Forms.TextBox generatedGodLabel;
        private System.Windows.Forms.Button infoButton;
    }
}

