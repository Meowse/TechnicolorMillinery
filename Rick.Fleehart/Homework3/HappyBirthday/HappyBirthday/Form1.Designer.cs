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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.AskNameLabel = new System.Windows.Forms.Label();
            this.SelectedDate = new System.Windows.Forms.Label();
            this.ChooseBDaylabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(53, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(206, 29);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Is it your Birthday?";
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(190, 76);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 20);
            this.NametextBox.TabIndex = 1;
            // 
            // AskNameLabel
            // 
            this.AskNameLabel.AutoSize = true;
            this.AskNameLabel.Location = new System.Drawing.Point(50, 79);
            this.AskNameLabel.Name = "AskNameLabel";
            this.AskNameLabel.Size = new System.Drawing.Size(134, 13);
            this.AskNameLabel.TabIndex = 3;
            this.AskNameLabel.Text = "1. Please enter Your Name";
            // 
            // SelectedDate
            // 
            this.SelectedDate.AutoSize = true;
            this.SelectedDate.Location = new System.Drawing.Point(131, 146);
            this.SelectedDate.Name = "SelectedDate";
            this.SelectedDate.Size = new System.Drawing.Size(167, 13);
            this.SelectedDate.TabIndex = 4;
            this.SelectedDate.Text = "(choose from the calendar please)";
            // 
            // ChooseBDaylabel
            // 
            this.ChooseBDaylabel.AutoSize = true;
            this.ChooseBDaylabel.Location = new System.Drawing.Point(50, 112);
            this.ChooseBDaylabel.Name = "ChooseBDaylabel";
            this.ChooseBDaylabel.Size = new System.Drawing.Size(271, 13);
            this.ChooseBDaylabel.TabIndex = 5;
            this.ChooseBDaylabel.Text = "2. Choose your birthday from the calendar on the right ->";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(418, 29);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your Birthday:";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(55, 177);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(13, 13);
            this.OutputLabel.TabIndex = 8;
            this.OutputLabel.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 371);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.ChooseBDaylabel);
            this.Controls.Add(this.SelectedDate);
            this.Controls.Add(this.AskNameLabel);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label AskNameLabel;
        private System.Windows.Forms.Label SelectedDate;
        private System.Windows.Forms.Label ChooseBDaylabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OutputLabel;
    }
}

