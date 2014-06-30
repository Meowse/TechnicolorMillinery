namespace BrushTeethWFA
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
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.CloseMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World... Click the button for instructions on how to brush your teeth";
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Location = new System.Drawing.Point(374, 90);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(75, 23);
            this.ClickMeButton.TabIndex = 1;
            this.ClickMeButton.Text = "Click Me";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButtonClicked);
            // 
            // CloseMeButton
            // 
            this.CloseMeButton.Location = new System.Drawing.Point(374, 199);
            this.CloseMeButton.Name = "CloseMeButton";
            this.CloseMeButton.Size = new System.Drawing.Size(75, 23);
            this.CloseMeButton.TabIndex = 2;
            this.CloseMeButton.Text = "Close me";
            this.CloseMeButton.UseVisualStyleBackColor = true;
            this.CloseMeButton.Click += new System.EventHandler(this.CloseMeButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 276);
            this.Controls.Add(this.CloseMeButton);
            this.Controls.Add(this.ClickMeButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.Button CloseMeButton;
    }
}

