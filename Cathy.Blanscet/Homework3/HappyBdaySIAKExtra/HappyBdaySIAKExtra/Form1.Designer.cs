namespace HappyBdaySIAKExtra
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.BDayLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BDayBox = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(82, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(138, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "1) Enter Your Name:";
            // 
            // BDayLabel
            // 
            this.BDayLabel.AutoSize = true;
            this.BDayLabel.Location = new System.Drawing.Point(51, 51);
            this.BDayLabel.Name = "BDayLabel";
            this.BDayLabel.Size = new System.Drawing.Size(169, 17);
            this.BDayLabel.TabIndex = 1;
            this.BDayLabel.Text = "2) Choose your birthdate:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(232, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 2;
            // 
            // BDayBox
            // 
            this.BDayBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BDayBox.Location = new System.Drawing.Point(232, 51);
            this.BDayBox.Name = "BDayBox";
            this.BDayBox.Size = new System.Drawing.Size(130, 22);
            this.BDayBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "3) Click Me, for a message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClickMeClicked);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(386, 12);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(16, 17);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1100, 309);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BDayBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.BDayLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Is It Your Birthday (Methods)?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BDayLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.DateTimePicker BDayBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ResultLabel;
    }
}

