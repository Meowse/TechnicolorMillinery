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
            this.GetTime = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BirthMonthText = new System.Windows.Forms.TextBox();
            this.BirthYearText = new System.Windows.Forms.TextBox();
            this.BinaryAge = new System.Windows.Forms.Button();
            this.BinaryLabel = new System.Windows.Forms.Label();
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
            this.BirthdayText.Location = new System.Drawing.Point(133, 123);
            this.BirthdayText.Name = "BirthdayText";
            this.BirthdayText.Size = new System.Drawing.Size(34, 20);
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
            this.BirthdayButton.Click += new System.EventHandler(this.BirthdayButton_Click);
            // 
            // GetTime
            // 
            this.GetTime.Location = new System.Drawing.Point(428, 10);
            this.GetTime.Name = "GetTime";
            this.GetTime.Size = new System.Drawing.Size(121, 23);
            this.GetTime.TabIndex = 8;
            this.GetTime.Text = "What day is it?";
            this.GetTime.UseVisualStyleBackColor = true;
            this.GetTime.Click += new System.EventHandler(this.DateTime_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Time of Day:";
            // 
            // BirthMonthText
            // 
            this.BirthMonthText.Location = new System.Drawing.Point(173, 123);
            this.BirthMonthText.Name = "BirthMonthText";
            this.BirthMonthText.Size = new System.Drawing.Size(34, 20);
            this.BirthMonthText.TabIndex = 14;
            // 
            // BirthYearText
            // 
            this.BirthYearText.Location = new System.Drawing.Point(213, 123);
            this.BirthYearText.Name = "BirthYearText";
            this.BirthYearText.Size = new System.Drawing.Size(34, 20);
            this.BirthYearText.TabIndex = 15;
            // 
            // BinaryAge
            // 
            this.BinaryAge.Location = new System.Drawing.Point(133, 207);
            this.BinaryAge.Name = "BinaryAge";
            this.BinaryAge.Size = new System.Drawing.Size(160, 23);
            this.BinaryAge.TabIndex = 16;
            this.BinaryAge.Text = "Give me my age in binary";
            this.BinaryAge.UseVisualStyleBackColor = true;
            this.BinaryAge.Click += new System.EventHandler(this.BinaryAge_Click);
            // 
            // BinaryLabel
            // 
            this.BinaryLabel.AutoSize = true;
            this.BinaryLabel.Location = new System.Drawing.Point(312, 216);
            this.BinaryLabel.Name = "BinaryLabel";
            this.BinaryLabel.Size = new System.Drawing.Size(88, 13);
            this.BinaryLabel.TabIndex = 17;
            this.BinaryLabel.Text = "                           ";
            // 
            // IntroductionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 400);
            this.Controls.Add(this.BinaryLabel);
            this.Controls.Add(this.BinaryAge);
            this.Controls.Add(this.BirthYearText);
            this.Controls.Add(this.BirthMonthText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GetTime);
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
        private System.Windows.Forms.Button GetTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BirthMonthText;
        private System.Windows.Forms.TextBox BirthYearText;
        private System.Windows.Forms.Button BinaryAge;
        private System.Windows.Forms.Label BinaryLabel;
    }
}

