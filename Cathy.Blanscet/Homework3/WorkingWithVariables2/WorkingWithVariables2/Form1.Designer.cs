namespace WorkingWithVariables2
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
            this.ClickMeLabel = new System.Windows.Forms.Label();
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClickMeLabel
            // 
            this.ClickMeLabel.AutoSize = true;
            this.ClickMeLabel.Location = new System.Drawing.Point(41, 22);
            this.ClickMeLabel.Name = "ClickMeLabel";
            this.ClickMeLabel.Size = new System.Drawing.Size(321, 17);
            this.ClickMeLabel.TabIndex = 0;
            this.ClickMeLabel.Text = "Click the button Click Me and watch what happens";
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Location = new System.Drawing.Point(44, 97);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(75, 23);
            this.ClickMeButton.TabIndex = 1;
            this.ClickMeButton.Text = "Click Me";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 253);
            this.Controls.Add(this.ClickMeButton);
            this.Controls.Add(this.ClickMeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClickMeLabel;
        private System.Windows.Forms.Button ClickMeButton;
    }
}

