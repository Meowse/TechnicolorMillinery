namespace WindowsFormsApplication1
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
            this.DoSomethingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Windows Forms Application!\r\n\r\nIt\'s very easy to play with.";
            // 
            // DoSomethingButton
            // 
            this.DoSomethingButton.Location = new System.Drawing.Point(172, 68);
            this.DoSomethingButton.Name = "DoSomethingButton";
            this.DoSomethingButton.Size = new System.Drawing.Size(184, 38);
            this.DoSomethingButton.TabIndex = 1;
            this.DoSomethingButton.Text = "Do Something!";
            this.DoSomethingButton.UseVisualStyleBackColor = true;
            this.DoSomethingButton.Click += new System.EventHandler(this.DoSomethingClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 118);
            this.Controls.Add(this.DoSomethingButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Windows for Fun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DoSomethingButton;
    }
}

