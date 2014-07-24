namespace HappyBirthday
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
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.your_birthday_label = new System.Windows.Forms.Label();
            this.your_birthday_textbox = new System.Windows.Forms.TextBox();
            this.enter_button = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(184, 127);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(160, 20);
            this.name_textbox.TabIndex = 0;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(83, 134);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name";
            // 
            // your_birthday_label
            // 
            this.your_birthday_label.AutoSize = true;
            this.your_birthday_label.Location = new System.Drawing.Point(83, 168);
            this.your_birthday_label.Name = "your_birthday_label";
            this.your_birthday_label.Size = new System.Drawing.Size(70, 13);
            this.your_birthday_label.TabIndex = 2;
            this.your_birthday_label.Text = "Your Birthday";
            // 
            // your_birthday_textbox
            // 
            this.your_birthday_textbox.Location = new System.Drawing.Point(184, 168);
            this.your_birthday_textbox.Name = "your_birthday_textbox";
            this.your_birthday_textbox.Size = new System.Drawing.Size(160, 20);
            this.your_birthday_textbox.TabIndex = 3;
            // 
            // enter_button
            // 
            this.enter_button.Location = new System.Drawing.Point(318, 212);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(148, 23);
            this.enter_button.TabIndex = 5;
            this.enter_button.Text = "Click for Surprise";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(382, 38);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 592);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.your_birthday_textbox);
            this.Controls.Add(this.your_birthday_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_textbox);
            this.Name = "Form1";
            this.Text = "Date Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label your_birthday_label;
        private System.Windows.Forms.TextBox your_birthday_textbox;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

