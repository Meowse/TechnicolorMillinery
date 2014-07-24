namespace HW_2_Part_2
{
    partial class BrushInstructions
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
            this.BrushTeethButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.NoThankYou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BrushTeethButton
            // 
            this.BrushTeethButton.Location = new System.Drawing.Point(3, 57);
            this.BrushTeethButton.Name = "BrushTeethButton";
            this.BrushTeethButton.Size = new System.Drawing.Size(118, 67);
            this.BrushTeethButton.TabIndex = 0;
            this.BrushTeethButton.Text = "Give Me Help!";
            this.BrushTeethButton.UseVisualStyleBackColor = true;
            this.BrushTeethButton.Click += new System.EventHandler(this.BrushTeeth);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(0, 20);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(218, 13);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Do you need some help brushing your teeth?";
            // 
            // NoThankYou
            // 
            this.NoThankYou.Location = new System.Drawing.Point(140, 57);
            this.NoThankYou.Name = "NoThankYou";
            this.NoThankYou.Size = new System.Drawing.Size(118, 67);
            this.NoThankYou.TabIndex = 2;
            this.NoThankYou.Text = "I\'m an Expert";
            this.NoThankYou.UseVisualStyleBackColor = true;
            this.NoThankYou.Click += new System.EventHandler(this.ExpertStatus);
            // 
            // BrushInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.NoThankYou);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.BrushTeethButton);
            this.Name = "BrushInstructions";
            this.Text = "Teeth Brushing Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrushTeethButton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button NoThankYou;
    }
}

