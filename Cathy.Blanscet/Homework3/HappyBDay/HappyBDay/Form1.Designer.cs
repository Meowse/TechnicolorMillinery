namespace HappyBDay
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BDayLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.BDayBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Location = new System.Drawing.Point(22, 56);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(75, 23);
            this.ClickMeButton.TabIndex = 0;
            this.ClickMeButton.Text = "Click Me";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeClicked);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(144, 26);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(129, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(19, 26);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(119, 17);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Enter your Name:";
            // 
            // BDayLabel
            // 
            this.BDayLabel.AutoSize = true;
            this.BDayLabel.Location = new System.Drawing.Point(291, 26);
            this.BDayLabel.Name = "BDayLabel";
            this.BDayLabel.Size = new System.Drawing.Size(152, 17);
            this.BDayLabel.TabIndex = 4;
            this.BDayLabel.Text = "Choose your birthdate:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(19, 82);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(12, 17);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = " ";
            // 
            // BDayBox
            // 
            this.BDayBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BDayBox.Location = new System.Drawing.Point(440, 26);
            this.BDayBox.Name = "BDayBox";
            this.BDayBox.Size = new System.Drawing.Size(127, 22);
            this.BDayBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 538);
            this.Controls.Add(this.BDayBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.BDayLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ClickMeButton);
            this.Name = "Form1";
            this.Text = "Birthday Greetings?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BDayLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.DateTimePicker BDayBox;
    }
}

