namespace HappyBirthdayExtraCredit
{
    partial class month_calendar
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
            this.name_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.your_birthday_label = new System.Windows.Forms.Label();
            this.your_birthday_textbox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.click_for_surprise_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(77, 63);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(220, 63);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(228, 20);
            this.name_textbox.TabIndex = 1;
            // 
            // your_birthday_label
            // 
            this.your_birthday_label.AutoSize = true;
            this.your_birthday_label.Location = new System.Drawing.Point(77, 113);
            this.your_birthday_label.Name = "your_birthday_label";
            this.your_birthday_label.Size = new System.Drawing.Size(70, 13);
            this.your_birthday_label.TabIndex = 2;
            this.your_birthday_label.Text = "Your Birthday";
            // 
            // your_birthday_textbox
            // 
            this.your_birthday_textbox.Location = new System.Drawing.Point(220, 113);
            this.your_birthday_textbox.Name = "your_birthday_textbox";
            this.your_birthday_textbox.Size = new System.Drawing.Size(189, 20);
            this.your_birthday_textbox.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(421, 113);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // click_for_surprise_button
            // 
            this.click_for_surprise_button.Location = new System.Drawing.Point(292, 320);
            this.click_for_surprise_button.Name = "click_for_surprise_button";
            this.click_for_surprise_button.Size = new System.Drawing.Size(140, 23);
            this.click_for_surprise_button.TabIndex = 5;
            this.click_for_surprise_button.Text = "Click for Surprise";
            this.click_for_surprise_button.UseVisualStyleBackColor = true;
            // 
            // month_calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 638);
            this.Controls.Add(this.click_for_surprise_button);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.your_birthday_textbox);
            this.Controls.Add(this.your_birthday_label);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.name_label);
            this.Name = "month_calendar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label your_birthday_label;
        private System.Windows.Forms.TextBox your_birthday_textbox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button click_for_surprise_button;
    }
}

