namespace HappybirthdayStarter
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
            this.label1 = new System.Windows.Forms.Label();
            this.namefield = new System.Windows.Forms.TextBox();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.enteredDate = new System.Windows.Forms.TextBox();
            this.agelabel = new System.Windows.Forms.Label();
            this.binarylabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name, please.";
            // 
            // namefield
            // 
            this.namefield.Location = new System.Drawing.Point(142, 32);
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(100, 20);
            this.namefield.TabIndex = 1;
            // 
            // Submitbutton
            // 
            this.Submitbutton.Location = new System.Drawing.Point(111, 125);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(153, 23);
            this.Submitbutton.TabIndex = 2;
            this.Submitbutton.Text = "Submit name and birthdate";
            this.Submitbutton.UseVisualStyleBackColor = true;
            this.Submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your birthday in this format (mm/dd/yyyy)";
            // 
            // enteredDate
            // 
            this.enteredDate.Location = new System.Drawing.Point(248, 73);
            this.enteredDate.Name = "enteredDate";
            this.enteredDate.Size = new System.Drawing.Size(100, 20);
            this.enteredDate.TabIndex = 4;
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Location = new System.Drawing.Point(44, 182);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(50, 13);
            this.agelabel.TabIndex = 5;
            this.agelabel.Text = "Your age";
            // 
            // binarylabel
            // 
            this.binarylabel.AutoSize = true;
            this.binarylabel.Location = new System.Drawing.Point(44, 214);
            this.binarylabel.Name = "binarylabel";
            this.binarylabel.Size = new System.Drawing.Size(92, 13);
            this.binarylabel.TabIndex = 6;
            this.binarylabel.Text = "Your age in binary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 270);
            this.Controls.Add(this.binarylabel);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.enteredDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.namefield);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namefield;
        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enteredDate;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.Label binarylabel;
    }
}

