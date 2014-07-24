namespace VariablesandConditionals
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
            this.greetingsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.AutoSize = true;
            this.greetingsLabel.Location = new System.Drawing.Point(28, 39);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.Size = new System.Drawing.Size(35, 13);
            this.greetingsLabel.TabIndex = 0;
            this.greetingsLabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(83, 109);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 20);
            this.nameField.TabIndex = 2;
            this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.greetingsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameField;
    }
}

