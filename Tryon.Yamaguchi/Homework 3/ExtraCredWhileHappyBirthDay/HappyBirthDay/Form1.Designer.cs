namespace HappyBirthDay
{
    partial class frmHappyBirthday
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
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpCalendar = new System.Windows.Forms.DateTimePicker();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblHBDSong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(54, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Your Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Your Date of Birth:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 22);
            this.txtName.TabIndex = 2;
            // 
            // dtpCalendar
            // 
            this.dtpCalendar.Location = new System.Drawing.Point(182, 59);
            this.dtpCalendar.Name = "dtpCalendar";
            this.dtpCalendar.Size = new System.Drawing.Size(226, 22);
            this.dtpCalendar.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(57, 96);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblHBDSong
            // 
            this.lblHBDSong.AutoSize = true;
            this.lblHBDSong.Location = new System.Drawing.Point(182, 194);
            this.lblHBDSong.Name = "lblHBDSong";
            this.lblHBDSong.Size = new System.Drawing.Size(0, 17);
            this.lblHBDSong.TabIndex = 5;
            // 
            // frmHappyBirthday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 381);
            this.Controls.Add(this.lblHBDSong);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dtpCalendar);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Name = "frmHappyBirthday";
            this.Text = "Happy Birthday";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpCalendar;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblHBDSong;
    }
}

