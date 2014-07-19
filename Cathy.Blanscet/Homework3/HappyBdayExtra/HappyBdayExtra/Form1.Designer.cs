namespace HappyBdayExtra
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
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BDayBox = new System.Windows.Forms.DateTimePicker();
            this.BDayLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.BirthYearTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Location = new System.Drawing.Point(15, 38);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(75, 23);
            this.ClickMeButton.TabIndex = 0;
            this.ClickMeButton.Text = "Click Me";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeClicked);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 18);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(121, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Enter Your Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(144, 18);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(134, 22);
            this.NameTextBox.TabIndex = 2;
            // 
            // BDayBox
            // 
            this.BDayBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BDayBox.Location = new System.Drawing.Point(465, 18);
            this.BDayBox.Name = "BDayBox";
            this.BDayBox.Size = new System.Drawing.Size(125, 22);
            this.BDayBox.TabIndex = 3;
            // 
            // BDayLabel
            // 
            this.BDayLabel.AutoSize = true;
            this.BDayLabel.Location = new System.Drawing.Point(307, 18);
            this.BDayLabel.Name = "BDayLabel";
            this.BDayLabel.Size = new System.Drawing.Size(152, 17);
            this.BDayLabel.TabIndex = 4;
            this.BDayLabel.Text = "Choose your birthdate:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 73);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(20, 17);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "   ";
            // 
            // BirthYearTextBox
            // 
            this.BirthYearTextBox.Location = new System.Drawing.Point(828, 18);
            this.BirthYearTextBox.Name = "BirthYearTextBox";
            this.BirthYearTextBox.Size = new System.Drawing.Size(100, 22);
            this.BirthYearTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter the year you were born:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthYearTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.BDayLabel);
            this.Controls.Add(this.BDayBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ClickMeButton);
            this.Name = "Form1";
            this.Text = "Birthday Greetings (While)?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.DateTimePicker BDayBox;
        private System.Windows.Forms.Label BDayLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox BirthYearTextBox;
        private System.Windows.Forms.Label label1;
    }
}

