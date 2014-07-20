namespace HappyBirthdaySuperDuperCredit
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
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.your_birthday_label = new System.Windows.Forms.Label();
            this.your_birthday_textbox = new System.Windows.Forms.TextBox();
            this.surprise_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(125, 83);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(175, 80);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(264, 20);
            this.name_textbox.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(347, 112);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // your_birthday_label
            // 
            this.your_birthday_label.AutoSize = true;
            this.your_birthday_label.Location = new System.Drawing.Point(99, 137);
            this.your_birthday_label.Name = "your_birthday_label";
            this.your_birthday_label.Size = new System.Drawing.Size(70, 13);
            this.your_birthday_label.TabIndex = 3;
            this.your_birthday_label.Text = "Your Birthday";
            this.your_birthday_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // your_birthday_textbox
            // 
            this.your_birthday_textbox.Location = new System.Drawing.Point(175, 134);
            this.your_birthday_textbox.Name = "your_birthday_textbox";
            this.your_birthday_textbox.Size = new System.Drawing.Size(160, 20);
            this.your_birthday_textbox.TabIndex = 4;
            // 
            // surprise_button
            // 
            this.surprise_button.Location = new System.Drawing.Point(312, 312);
            this.surprise_button.Name = "surprise_button";
            this.surprise_button.Size = new System.Drawing.Size(139, 23);
            this.surprise_button.TabIndex = 5;
            this.surprise_button.Text = "Click for Surprise";
            this.surprise_button.UseVisualStyleBackColor = true;
            this.surprise_button.Click += new System.EventHandler(this.surprise_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 558);
            this.Controls.Add(this.surprise_button);
            this.Controls.Add(this.your_birthday_textbox);
            this.Controls.Add(this.your_birthday_label);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.name_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label your_birthday_label;
        private System.Windows.Forms.TextBox your_birthday_textbox;
        private System.Windows.Forms.Button surprise_button;
    }
}

