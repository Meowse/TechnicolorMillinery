namespace HelloWorldForm
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
            this.helloworld_button = new System.Windows.Forms.Button();
            this.howtobrushteeth_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloworld_button
            // 
            this.helloworld_button.Location = new System.Drawing.Point(163, 133);
            this.helloworld_button.Name = "helloworld_button";
            this.helloworld_button.Size = new System.Drawing.Size(75, 23);
            this.helloworld_button.TabIndex = 0;
            this.helloworld_button.Text = "Hello World";
            this.helloworld_button.UseVisualStyleBackColor = true;
            this.helloworld_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // howtobrushteeth_button
            // 
            this.howtobrushteeth_button.Location = new System.Drawing.Point(244, 133);
            this.howtobrushteeth_button.Name = "howtobrushteeth_button";
            this.howtobrushteeth_button.Size = new System.Drawing.Size(126, 23);
            this.howtobrushteeth_button.TabIndex = 1;
            this.howtobrushteeth_button.Text = "How to Brush your teeth";
            this.howtobrushteeth_button.UseVisualStyleBackColor = true;
            this.howtobrushteeth_button.Click += new System.EventHandler(this.howtobrushteeth_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 584);
            this.Controls.Add(this.howtobrushteeth_button);
            this.Controls.Add(this.helloworld_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helloworld_button;
        private System.Windows.Forms.Button howtobrushteeth_button;
    }
}

