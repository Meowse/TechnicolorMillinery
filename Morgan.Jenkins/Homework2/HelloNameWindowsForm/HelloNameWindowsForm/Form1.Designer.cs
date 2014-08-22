namespace HelloNameWindowsForm
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
            this.greetinglabel = new System.Windows.Forms.Label();
            this.namefield = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greetinglabel
            // 
            this.greetinglabel.AutoSize = true;
            this.greetinglabel.Location = new System.Drawing.Point(26, 75);
            this.greetinglabel.Name = "greetinglabel";
            this.greetinglabel.Size = new System.Drawing.Size(219, 13);
            this.greetinglabel.TabIndex = 0;
            this.greetinglabel.Text = "Enter your Name and click OK to be greeted!";
            // 
            // namefield
            // 
            this.namefield.Location = new System.Drawing.Point(12, 49);
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(179, 20);
            this.namefield.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clickedOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.namefield);
            this.Controls.Add(this.greetinglabel);
            this.Name = "Form1";
            this.Text = "Hello, You";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetinglabel;
        private System.Windows.Forms.TextBox namefield;
        private System.Windows.Forms.Button button1;
    }
}

