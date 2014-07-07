namespace HW1SuperExtra
{
    partial class SuperExtraCreditForm
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
            this.helloButton = new System.Windows.Forms.Button();
            this.brushteethButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloButton
            // 
            this.helloButton.Location = new System.Drawing.Point(25, 21);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(110, 30);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "hello";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.Click += new System.EventHandler(this.helloButton_click);
            // 
            // brushteethButton
            // 
            this.brushteethButton.Location = new System.Drawing.Point(25, 57);
            this.brushteethButton.Name = "brushteethButton";
            this.brushteethButton.Size = new System.Drawing.Size(110, 30);
            this.brushteethButton.TabIndex = 0;
            this.brushteethButton.Text = "brush";
            this.brushteethButton.UseVisualStyleBackColor = true;
            this.brushteethButton.Click += new System.EventHandler(this.brushbutton_click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(25, 93);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(110, 30);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // SuperExtraCreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 153);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.brushteethButton);
            this.Controls.Add(this.helloButton);
            this.Name = "SuperExtraCreditForm";
            this.Text = "SuperExtraCredit";
            this.Load += new System.EventHandler(this.SuperExtraCreditForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Button brushteethButton;
        private System.Windows.Forms.Button quitButton;
    }
}

