namespace Homework_3_Part_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.addNum = new System.Windows.Forms.Label();
            this.displayNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Me to Add Number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addNum
            // 
            this.addNum.AutoSize = true;
            this.addNum.Location = new System.Drawing.Point(119, 57);
            this.addNum.Name = "addNum";
            this.addNum.Size = new System.Drawing.Size(0, 13);
            this.addNum.TabIndex = 1;
            this.addNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // displayNum
            // 
            this.displayNum.AutoSize = true;
            this.displayNum.Location = new System.Drawing.Point(119, 57);
            this.displayNum.Name = "displayNum";
            this.displayNum.Size = new System.Drawing.Size(44, 13);
            this.displayNum.TabIndex = 2;
            this.displayNum.Text = "Number";
            this.displayNum.Click += new System.EventHandler(this.displayNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.displayNum);
            this.Controls.Add(this.addNum);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label addNum;
        private System.Windows.Forms.Label displayNum;
    }
}

