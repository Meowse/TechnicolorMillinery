namespace HappyBdaySDExtra
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
            this.SuspendLayout();
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Location = new System.Drawing.Point(5, 79);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(210, 30);
            this.ClickMeButton.TabIndex = 0;
            this.ClickMeButton.Text = "3) Click Me, for a message";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeClicked);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(77, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(138, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "1) Enter Your Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(221, 16);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(134, 22);
            this.NameTextBox.TabIndex = 2;
            // 
            // BDayBox
            // 
            this.BDayBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BDayBox.Location = new System.Drawing.Point(221, 51);
            this.BDayBox.Name = "BDayBox";
            this.BDayBox.Size = new System.Drawing.Size(125, 22);
            this.BDayBox.TabIndex = 3;
            // 
            // BDayLabel
            // 
            this.BDayLabel.AutoSize = true;
            this.BDayLabel.Location = new System.Drawing.Point(51, 51);
            this.BDayLabel.Name = "BDayLabel";
            this.BDayLabel.Size = new System.Drawing.Size(169, 17);
            this.BDayLabel.TabIndex = 4;
            this.BDayLabel.Text = "2) Choose your birthdate:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(391, 18);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(20, 17);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 586);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.BDayLabel);
            this.Controls.Add(this.BDayBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ClickMeButton);
            this.Name = "Form1";
            this.Text = "Is it your Birthday (Binary)?";
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
    }
}

