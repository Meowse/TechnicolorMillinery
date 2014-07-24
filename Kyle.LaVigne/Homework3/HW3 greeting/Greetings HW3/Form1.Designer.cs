namespace Greetings_HW3
{
    partial class IntroductionBox
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
            this.GreetingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BirthdayText = new System.Windows.Forms.TextBox();
            this.BirthdayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreetingButton
            // 
            this.GreetingButton.Location = new System.Drawing.Point(30, 60);
            this.GreetingButton.Name = "GreetingButton";
            this.GreetingButton.Size = new System.Drawing.Size(75, 23);
            this.GreetingButton.TabIndex = 0;
            this.GreetingButton.Text = "Greet me";
            this.GreetingButton.UseVisualStyleBackColor = true;
            this.GreetingButton.Click += new System.EventHandler(this.GreetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.AutoSize = true;
            this.GreetingLabel.Location = new System.Drawing.Point(147, 65);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(136, 13);
            this.GreetingLabel.TabIndex = 2;
            this.GreetingLabel.Text = "                                           ";
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(150, 10);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(100, 20);
            this.NameField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "When is your birthday? ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "(mm/dd/yyyy)";
            // 
            // BirthdayText
            // 
            this.BirthdayText.Location = new System.Drawing.Point(150, 120);
            this.BirthdayText.Name = "BirthdayText";
            this.BirthdayText.Size = new System.Drawing.Size(100, 20);
            this.BirthdayText.TabIndex = 6;
            // 
            // BirthdayButton
            // 
            this.BirthdayButton.Location = new System.Drawing.Point(30, 207);
            this.BirthdayButton.Name = "BirthdayButton";
            this.BirthdayButton.Size = new System.Drawing.Size(75, 23);
            this.BirthdayButton.TabIndex = 7;
            this.BirthdayButton.Text = "Done!";
            this.BirthdayButton.UseVisualStyleBackColor = true;
            this.BirthdayButton.Click += new System.EventHandler(this.BdayButton_Click);
            // 
            // IntroductionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 400);
            this.Controls.Add(this.BirthdayButton);
            this.Controls.Add(this.BirthdayText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.GreetingLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GreetingButton);
            this.Name = "IntroductionBox";
            this.Text = "Introductions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GreetingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GreetingLabel;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BirthdayText;
        private System.Windows.Forms.Button BirthdayButton;
    }
}

