namespace WorkingWithVaraiables
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
            this.TextBoxForName = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.LabelForTextbox = new System.Windows.Forms.Label();
            this.GreetMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxForName
            // 
            this.TextBoxForName.Location = new System.Drawing.Point(139, 27);
            this.TextBoxForName.Name = "TextBoxForName";
            this.TextBoxForName.Size = new System.Drawing.Size(100, 22);
            this.TextBoxForName.TabIndex = 0;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(281, 27);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(16, 17);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "  ";
            // 
            // LabelForTextbox
            // 
            this.LabelForTextbox.AutoSize = true;
            this.LabelForTextbox.Location = new System.Drawing.Point(84, 27);
            this.LabelForTextbox.Name = "LabelForTextbox";
            this.LabelForTextbox.Size = new System.Drawing.Size(49, 17);
            this.LabelForTextbox.TabIndex = 2;
            this.LabelForTextbox.Text = "Name:";
            // 
            // GreetMeButton
            // 
            this.GreetMeButton.Location = new System.Drawing.Point(135, 65);
            this.GreetMeButton.Name = "GreetMeButton";
            this.GreetMeButton.Size = new System.Drawing.Size(104, 23);
            this.GreetMeButton.TabIndex = 3;
            this.GreetMeButton.Text = "Greet Me!";
            this.GreetMeButton.UseVisualStyleBackColor = true;
            this.GreetMeButton.Click += new System.EventHandler(this.GreetMeClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 182);
            this.Controls.Add(this.GreetMeButton);
            this.Controls.Add(this.LabelForTextbox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.TextBoxForName);
            this.Name = "Form1";
            this.Text = "Greetings Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxForName;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label LabelForTextbox;
        private System.Windows.Forms.Button GreetMeButton;
    }
}

