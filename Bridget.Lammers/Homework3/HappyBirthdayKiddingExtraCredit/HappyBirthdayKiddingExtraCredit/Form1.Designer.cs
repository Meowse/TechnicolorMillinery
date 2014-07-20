namespace HappyBirthdayKiddingExtraCredit
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
            this.name_label = new System.Windows.Forms.Label();
            this.your_birthday_lable = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.your_birthday_textbox = new System.Windows.Forms.TextBox();
            this.click_for_surprise_button = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(145, 80);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // your_birthday_lable
            // 
            this.your_birthday_lable.AutoSize = true;
            this.your_birthday_lable.Location = new System.Drawing.Point(128, 153);
            this.your_birthday_lable.Name = "your_birthday_lable";
            this.your_birthday_lable.Size = new System.Drawing.Size(70, 13);
            this.your_birthday_lable.TabIndex = 1;
            this.your_birthday_lable.Text = "Your Birthday";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(186, 77);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(282, 20);
            this.name_textbox.TabIndex = 2;
            // 
            // your_birthday_textbox
            // 
            this.your_birthday_textbox.Location = new System.Drawing.Point(204, 146);
            this.your_birthday_textbox.Name = "your_birthday_textbox";
            this.your_birthday_textbox.Size = new System.Drawing.Size(248, 20);
            this.your_birthday_textbox.TabIndex = 3;
            // 
            // click_for_surprise_button
            // 
            this.click_for_surprise_button.Location = new System.Drawing.Point(275, 260);
            this.click_for_surprise_button.Name = "click_for_surprise_button";
            this.click_for_surprise_button.Size = new System.Drawing.Size(193, 23);
            this.click_for_surprise_button.TabIndex = 4;
            this.click_for_surprise_button.Text = "Click for Surprise";
            this.click_for_surprise_button.UseVisualStyleBackColor = true;
            this.click_for_surprise_button.Click += new System.EventHandler(this.click_for_surprise_button_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(480, 84);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 625);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.click_for_surprise_button);
            this.Controls.Add(this.your_birthday_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.your_birthday_lable);
            this.Controls.Add(this.name_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label your_birthday_lable;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox your_birthday_textbox;
        private System.Windows.Forms.Button click_for_surprise_button;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

