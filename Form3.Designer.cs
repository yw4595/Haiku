namespace Haiku
{
    partial class AboutForm
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
            this.aboutLabel = new System.Windows.Forms.Label();
            this.aboutgenerateButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            this.aboutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Location = new System.Drawing.Point(90, 67);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(208, 13);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "Click the button to generate a haiku poem!";
            // 
            // aboutgenerateButton
            // 
            this.aboutgenerateButton.Location = new System.Drawing.Point(146, 135);
            this.aboutgenerateButton.Name = "aboutgenerateButton";
            this.aboutgenerateButton.Size = new System.Drawing.Size(75, 23);
            this.aboutgenerateButton.TabIndex = 1;
            this.aboutgenerateButton.Text = "Generate";
            this.aboutgenerateButton.UseVisualStyleBackColor = true;
            this.aboutgenerateButton.Click += new System.EventHandler(this.aboutgenerateButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 245);
            this.Controls.Add(this.aboutgenerateButton);
            this.Controls.Add(this.aboutLabel);
            this.Name = "AboutForm";
            this.Text = "About Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Button aboutgenerateButton;
        private System.Windows.Forms.Timer timer1;
    }
}