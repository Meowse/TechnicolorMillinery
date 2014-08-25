namespace WinFormsEventHandling
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
            this.nikeButton = new System.Windows.Forms.Button();
            this.otherButton = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.addBlankLineButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nikeButton
            // 
            this.nikeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nikeButton.Location = new System.Drawing.Point(756, 355);
            this.nikeButton.Name = "nikeButton";
            this.nikeButton.Size = new System.Drawing.Size(75, 23);
            this.nikeButton.TabIndex = 0;
            this.nikeButton.Text = "Do It!";
            this.nikeButton.UseVisualStyleBackColor = true;
            // 
            // otherButton
            // 
            this.otherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.otherButton.Location = new System.Drawing.Point(12, 355);
            this.otherButton.Name = "otherButton";
            this.otherButton.Size = new System.Drawing.Size(75, 23);
            this.otherButton.TabIndex = 1;
            this.otherButton.Text = "Other!";
            this.otherButton.UseVisualStyleBackColor = true;
            this.otherButton.Click += new System.EventHandler(this.otherButton_Click);
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Location = new System.Drawing.Point(13, 13);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(818, 336);
            this.output.TabIndex = 2;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(360, 355);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addBlankLineButton
            // 
            this.addBlankLineButton.Location = new System.Drawing.Point(441, 355);
            this.addBlankLineButton.Name = "addBlankLineButton";
            this.addBlankLineButton.Size = new System.Drawing.Size(75, 23);
            this.addBlankLineButton.TabIndex = 4;
            this.addBlankLineButton.Text = "Blank Line";
            this.addBlankLineButton.UseVisualStyleBackColor = true;
            this.addBlankLineButton.Click += new System.EventHandler(this.addBlankLineButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Do Nothing";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addBlankLineButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.output);
            this.Controls.Add(this.otherButton);
            this.Controls.Add(this.nikeButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "WinForms Event-Handling Example";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.handleKeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.handleKeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nikeButton;
        private System.Windows.Forms.Button otherButton;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addBlankLineButton;
        private System.Windows.Forms.Button button1;
    }
}

