namespace Haiku
{
    partial class SettingsForm
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
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.syllablesPerLineNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numLinesCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.generateButton1 = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.errorTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.syllablesPerLineNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // styleComboBox
            // 
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Items.AddRange(new object[] {
            "Traditional",
            "Modern"});
            this.styleComboBox.Location = new System.Drawing.Point(98, 25);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(150, 21);
            this.styleComboBox.TabIndex = 0;
            // 
            // syllablesPerLineNumericUpDown
            // 
            this.syllablesPerLineNumericUpDown.Location = new System.Drawing.Point(183, 65);
            this.syllablesPerLineNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.syllablesPerLineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.syllablesPerLineNumericUpDown.Name = "syllablesPerLineNumericUpDown";
            this.syllablesPerLineNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.syllablesPerLineNumericUpDown.TabIndex = 1;
            this.syllablesPerLineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numLinesCheckBox
            // 
            this.numLinesCheckBox.AutoSize = true;
            this.numLinesCheckBox.Location = new System.Drawing.Point(98, 95);
            this.numLinesCheckBox.Name = "numLinesCheckBox";
            this.numLinesCheckBox.Size = new System.Drawing.Size(136, 17);
            this.numLinesCheckBox.TabIndex = 2;
            this.numLinesCheckBox.Text = "Use 4 lines instead of 3";
            this.numLinesCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(98, 134);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // generateButton1
            // 
            this.generateButton1.Location = new System.Drawing.Point(98, 207);
            this.generateButton1.Name = "generateButton1";
            this.generateButton1.Size = new System.Drawing.Size(75, 23);
            this.generateButton1.TabIndex = 5;
            this.generateButton1.Text = "Generate";
            this.generateButton1.UseVisualStyleBackColor = true;
            this.generateButton1.Click += new System.EventHandler(this.generateButton1_Click);
            this.generateButton1.MouseHover += new System.EventHandler(this.generateButton1_MouseHover);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(216, 207);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 6;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // errorTimer
            // 
            this.errorTimer.Enabled = true;
            this.errorTimer.Interval = 5;
            this.errorTimer.Tick += new System.EventHandler(this.ErrorTimer_Tick);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 316);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.generateButton1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.numLinesCheckBox);
            this.Controls.Add(this.syllablesPerLineNumericUpDown);
            this.Controls.Add(this.styleComboBox);
            this.Name = "SettingsForm";
            this.Text = "Settings Form";
            ((System.ComponentModel.ISupportInitialize)(this.syllablesPerLineNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.NumericUpDown syllablesPerLineNumericUpDown;
        private System.Windows.Forms.CheckBox numLinesCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button generateButton1;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Timer errorTimer;
    }
}