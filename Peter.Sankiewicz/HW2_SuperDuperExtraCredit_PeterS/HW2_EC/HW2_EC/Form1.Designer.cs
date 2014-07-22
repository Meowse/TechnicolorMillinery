namespace HW2_EC
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.greetingsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addOne = new System.Windows.Forms.Button();
            this.myIntegerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(113, 38);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 20);
            this.nameField.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Greet Me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GreetThem);
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.AutoSize = true;
            this.greetingsLabel.Location = new System.Drawing.Point(72, 61);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.Size = new System.Drawing.Size(58, 13);
            this.greetingsLabel.TabIndex = 2;
            this.greetingsLabel.Text = "                 ";
            this.greetingsLabel.Click += new System.EventHandler(this.greetingsLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hello, please enter your name and click \"Greet Me!\"";
            // 
            // addOne
            // 
            this.addOne.Location = new System.Drawing.Point(78, 106);
            this.addOne.Name = "addOne";
            this.addOne.Size = new System.Drawing.Size(75, 23);
            this.addOne.TabIndex = 5;
            this.addOne.Text = "Add 1";
            this.addOne.UseVisualStyleBackColor = true;
            this.addOne.Click += new System.EventHandler(this.addOneTo_myIntgerValue);
            // 
            // myIntegerLabel
            // 
            this.myIntegerLabel.AutoSize = true;
            this.myIntegerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.myIntegerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myIntegerLabel.Location = new System.Drawing.Point(179, 110);
            this.myIntegerLabel.Name = "myIntegerLabel";
            this.myIntegerLabel.Size = new System.Drawing.Size(36, 15);
            this.myIntegerLabel.TabIndex = 6;
            this.myIntegerLabel.Text = "         ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 218);
            this.Controls.Add(this.myIntegerLabel);
            this.Controls.Add(this.addOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.greetingsLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameField);
            this.Name = "Form1";
            this.Text = "Greet Me!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label greetingsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addOne;
        private System.Windows.Forms.Label myIntegerLabel;
    }
}

