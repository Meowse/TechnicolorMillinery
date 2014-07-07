namespace WFA_WorkingWithVariables
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
            this.GreetMeButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClickMeLabel = new System.Windows.Forms.Button();
            this.IncrementNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreetMeButton
            // 
            this.GreetMeButton.Location = new System.Drawing.Point(545, 64);
            this.GreetMeButton.Name = "GreetMeButton";
            this.GreetMeButton.Size = new System.Drawing.Size(135, 23);
            this.GreetMeButton.TabIndex = 0;
            this.GreetMeButton.Text = "Greet Me!";
            this.GreetMeButton.UseVisualStyleBackColor = true;
            this.GreetMeButton.Click += new System.EventHandler(this.GreetMeButtonClicked);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(171, 64);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(207, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Homework2 - Fun with Variables part 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Homework2 - Fun with Variables part 2";
            // 
            // ClickMeLabel
            // 
            this.ClickMeLabel.Location = new System.Drawing.Point(56, 156);
            this.ClickMeLabel.Name = "ClickMeLabel";
            this.ClickMeLabel.Size = new System.Drawing.Size(228, 92);
            this.ClickMeLabel.TabIndex = 5;
            this.ClickMeLabel.Text = "Click the button Click Me and watch what happens";
            this.ClickMeLabel.UseVisualStyleBackColor = true;
            // 
            // IncrementNumberButton
            // 
            this.IncrementNumberButton.Location = new System.Drawing.Point(545, 156);
            this.IncrementNumberButton.Name = "IncrementNumberButton";
            this.IncrementNumberButton.Size = new System.Drawing.Size(75, 23);
            this.IncrementNumberButton.TabIndex = 6;
            this.IncrementNumberButton.Text = "Click Me";
            this.IncrementNumberButton.UseVisualStyleBackColor = true;
            this.IncrementNumberButton.Click += new System.EventHandler(this.IncrementNumberButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 306);
            this.Controls.Add(this.IncrementNumberButton);
            this.Controls.Add(this.ClickMeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.GreetMeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GreetMeButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClickMeLabel;
        private System.Windows.Forms.Button IncrementNumberButton;
    }
}

