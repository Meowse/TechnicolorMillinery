namespace RetrieveText
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
            this.retrieve_button = new System.Windows.Forms.Button();
            this.howto_button = new System.Windows.Forms.Button();
            this.hello_bridget_button = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.display_name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // retrieve_button
            // 
            this.retrieve_button.Location = new System.Drawing.Point(101, 274);
            this.retrieve_button.Name = "retrieve_button";
            this.retrieve_button.Size = new System.Drawing.Size(75, 23);
            this.retrieve_button.TabIndex = 0;
            this.retrieve_button.Text = "Retrieve";
            this.retrieve_button.UseVisualStyleBackColor = true;
            // 
            // howto_button
            // 
            this.howto_button.Location = new System.Drawing.Point(200, 274);
            this.howto_button.Name = "howto_button";
            this.howto_button.Size = new System.Drawing.Size(75, 23);
            this.howto_button.TabIndex = 1;
            this.howto_button.Text = "How To Brush Teeth";
            this.howto_button.UseVisualStyleBackColor = true;
            this.howto_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // hello_bridget_button
            // 
            this.hello_bridget_button.Location = new System.Drawing.Point(299, 274);
            this.hello_bridget_button.Name = "hello_bridget_button";
            this.hello_bridget_button.Size = new System.Drawing.Size(75, 23);
            this.hello_bridget_button.TabIndex = 2;
            this.hello_bridget_button.Text = "Hello Bridget";
            this.hello_bridget_button.UseVisualStyleBackColor = true;
            this.hello_bridget_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(81, 178);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(38, 13);
            this.name_label.TabIndex = 3;
            this.name_label.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 131);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 100);
            this.textBox1.TabIndex = 4;
            // 
            // display_name_label
            // 
            this.display_name_label.AutoSize = true;
            this.display_name_label.Location = new System.Drawing.Point(337, 178);
            this.display_name_label.Name = "display_name_label";
            this.display_name_label.Size = new System.Drawing.Size(72, 13);
            this.display_name_label.TabIndex = 5;
            this.display_name_label.Text = "Display Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 570);
            this.Controls.Add(this.display_name_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.hello_bridget_button);
            this.Controls.Add(this.howto_button);
            this.Controls.Add(this.retrieve_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retrieve_button;
        private System.Windows.Forms.Button howto_button;
        private System.Windows.Forms.Button hello_bridget_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label display_name_label;
    }
}

