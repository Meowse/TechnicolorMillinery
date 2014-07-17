namespace HW_2_EC_Part_1
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.GreetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(94, 13);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 20);
            this.nameField.TabIndex = 1;
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.AutoSize = true;
            this.GreetingLabel.Location = new System.Drawing.Point(133, 93);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(76, 13);
            this.GreetingLabel.TabIndex = 2;
            this.GreetingLabel.Text = "                       ";
            // 
            // GreetButton
            // 
            this.GreetButton.Location = new System.Drawing.Point(26, 79);
            this.GreetButton.Name = "GreetButton";
            this.GreetButton.Size = new System.Drawing.Size(85, 40);
            this.GreetButton.TabIndex = 3;
            this.GreetButton.Text = "Greet Me!";
            this.GreetButton.UseVisualStyleBackColor = true;
            this.GreetButton.Click += new System.EventHandler(this.GreetButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.GreetButton);
            this.Controls.Add(this.GreetingLabel);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Greetings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label GreetingLabel;
        private System.Windows.Forms.Button GreetButton;
    }
}

