namespace WinFormsApp
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
            this.doSomethingButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Windows Forms applications!  You can make GUIs (Graphical User Interfa" +
    "ces) just this easily!\r\n\r\nYou should all play around with Windows Forms applicat" +
    "ions, because they\'re fun.\r\n";
            // 
            // doSomethingButton
            // 
            this.doSomethingButton.Location = new System.Drawing.Point(175, 52);
            this.doSomethingButton.Name = "doSomethingButton";
            this.doSomethingButton.Size = new System.Drawing.Size(179, 30);
            this.doSomethingButton.TabIndex = 1;
            this.doSomethingButton.Text = "Do Something!";
            this.doSomethingButton.UseVisualStyleBackColor = true;
            this.doSomethingButton.Click += new System.EventHandler(this.DoSomethingClicked);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(466, 41);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(107, 41);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit!";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 94);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.doSomethingButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Best Window Ever!!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doSomethingButton;
        private System.Windows.Forms.Button quitButton;
    }
}

