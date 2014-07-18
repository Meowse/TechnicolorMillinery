namespace WorkingWithConditionals
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
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.IncrementLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Location = new System.Drawing.Point(85, 79);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(75, 23);
            this.ClickMeButton.TabIndex = 0;
            this.ClickMeButton.Text = "Click Me";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeClicked);
            // 
            // IncrementLabel
            // 
            this.IncrementLabel.AutoSize = true;
            this.IncrementLabel.Location = new System.Drawing.Point(43, 23);
            this.IncrementLabel.Name = "IncrementLabel";
            this.IncrementLabel.Size = new System.Drawing.Size(321, 17);
            this.IncrementLabel.TabIndex = 1;
            this.IncrementLabel.Text = "Click the button Click Me and watch what happens";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 253);
            this.Controls.Add(this.IncrementLabel);
            this.Controls.Add(this.ClickMeButton);
            this.Name = "Form1";
            this.Text = "Fun with Conditionals - Increment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.Label IncrementLabel;
    }
}

