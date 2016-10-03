namespace Random_God_Generator_Smite
{
    partial class Form1
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
            this.generatedGodLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // godClassSelectionComboBox
            // 
            this.godClassSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.godClassSelectionComboBox.FormattingEnabled = true;
            this.godClassSelectionComboBox.Location = new System.Drawing.Point(12, 12);
            this.godClassSelectionComboBox.Name = "godClassSelectionComboBox";
            this.godClassSelectionComboBox.Size = new System.Drawing.Size(177, 21);
            this.godClassSelectionComboBox.TabIndex = 0;
            this.godClassSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.godClassSelectionComboBox_SelectedIndexChanged);
            // 
            // generateRandomGodButton
            // 
            this.generateRandomGodButton.Location = new System.Drawing.Point(39, 62);
            this.generateRandomGodButton.Name = "generateRandomGodButton";
            this.generateRandomGodButton.Size = new System.Drawing.Size(122, 23);
            this.generateRandomGodButton.TabIndex = 1;
            this.generateRandomGodButton.Text = "Gen Random god";
            this.generateRandomGodButton.UseVisualStyleBackColor = true;
            this.generateRandomGodButton.Click += new System.EventHandler(this.generateRandomGodButton_Click);
            // 
            // generatedGodLabel
            // 
            this.generatedGodLabel.AutoSize = true;
            this.generatedGodLabel.Location = new System.Drawing.Point(79, 104);
            this.generatedGodLabel.Name = "generatedGodLabel";
            this.generatedGodLabel.Size = new System.Drawing.Size(35, 13);
            this.generatedGodLabel.TabIndex = 2;
            this.generatedGodLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.generatedGodLabel);
            this.Controls.Add(this.generateRandomGodButton);
            this.Controls.Add(this.godClassSelectionComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox godClassSelectionComboBox;
        private System.Windows.Forms.Button generateRandomGodButton;
        private System.Windows.Forms.Label generatedGodLabel;
    }
}

