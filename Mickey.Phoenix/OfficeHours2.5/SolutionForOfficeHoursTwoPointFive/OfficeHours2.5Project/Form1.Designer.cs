namespace OfficeHours2._5Project
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
            this.openNamedItRightButton = new System.Windows.Forms.Button();
            this.otherGoodNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openNamedItRightButton
            // 
            this.openNamedItRightButton.Location = new System.Drawing.Point(13, 13);
            this.openNamedItRightButton.Name = "openNamedItRightButton";
            this.openNamedItRightButton.Size = new System.Drawing.Size(157, 36);
            this.openNamedItRightButton.TabIndex = 0;
            this.openNamedItRightButton.Text = "Named it right!";
            this.openNamedItRightButton.UseVisualStyleBackColor = true;
            this.openNamedItRightButton.Click += new System.EventHandler(this.ShowNamedItRight);
            // 
            // otherGoodNameButton
            // 
            this.otherGoodNameButton.Location = new System.Drawing.Point(13, 55);
            this.otherGoodNameButton.Name = "otherGoodNameButton";
            this.otherGoodNameButton.Size = new System.Drawing.Size(157, 36);
            this.otherGoodNameButton.TabIndex = 1;
            this.otherGoodNameButton.Text = "Good name!";
            this.otherGoodNameButton.UseVisualStyleBackColor = true;
            this.otherGoodNameButton.Click += new System.EventHandler(this.ShowOtherGoodName);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 398);
            this.Controls.Add(this.otherGoodNameButton);
            this.Controls.Add(this.openNamedItRightButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openNamedItRightButton;
        private System.Windows.Forms.Button otherGoodNameButton;
    }
}

