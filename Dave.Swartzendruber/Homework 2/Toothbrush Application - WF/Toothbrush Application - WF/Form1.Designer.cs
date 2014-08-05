namespace Toothbrush_Application___WF
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
            this.toothBrushButton = new System.Windows.Forms.Button();
            this.sayHelloButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toothBrushButton
            // 
            this.toothBrushButton.Location = new System.Drawing.Point(123, 12);
            this.toothBrushButton.Name = "toothBrushButton";
            this.toothBrushButton.Size = new System.Drawing.Size(188, 54);
            this.toothBrushButton.TabIndex = 0;
            this.toothBrushButton.Text = "Click for Toothbrush Instructions";
            this.toothBrushButton.UseVisualStyleBackColor = true;
            this.toothBrushButton.Click += new System.EventHandler(this.toothBrush);
            // 
            // sayHelloButton
            // 
            this.sayHelloButton.Location = new System.Drawing.Point(123, 72);
            this.sayHelloButton.Name = "sayHelloButton";
            this.sayHelloButton.Size = new System.Drawing.Size(188, 54);
            this.sayHelloButton.TabIndex = 1;
            this.sayHelloButton.Text = "Say Hello";
            this.sayHelloButton.UseVisualStyleBackColor = true;
            this.sayHelloButton.Click += new System.EventHandler(this.sayHello);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 495);
            this.Controls.Add(this.sayHelloButton);
            this.Controls.Add(this.toothBrushButton);
            this.Name = "Form1";
            this.Text = "Tooth Brushing Instructions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toothBrushButton;
        private System.Windows.Forms.Button sayHelloButton;
    }
}

