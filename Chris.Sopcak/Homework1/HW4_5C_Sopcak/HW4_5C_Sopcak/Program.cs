using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_5C_Sopcak
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
            this.happyBirthday = new System.Windows.Forms.Button();
            this.ageBirthday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // happyBirthday
            // 
            this.happyBirthday.Location = new System.Drawing.Point(104, 72);
            this.happyBirthday.Name = "happyBirthday";
            this.happyBirthday.Size = new System.Drawing.Size(75, 23);
            this.happyBirthday.TabIndex = 0;
            this.happyBirthday.Text = "button1";
            this.happyBirthday.UseVisualStyleBackColor = true;
            this.happyBirthday.Click += new System.EventHandler(this.Form1_Load);
            // 
            // ageBirthday
            // 
            this.ageBirthday.Location = new System.Drawing.Point(104, 138);
            this.ageBirthday.Name = "ageBirthday";
            this.ageBirthday.Size = new System.Drawing.Size(75, 23);
            this.ageBirthday.TabIndex = 1;
            this.ageBirthday.Text = "button2";
            this.ageBirthday.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ageBirthday);
            this.Controls.Add(this.happyBirthday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button happyBirthday;
        private System.Windows.Forms.Button ageBirthday;
    }
}