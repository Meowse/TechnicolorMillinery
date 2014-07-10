namespace WorkingWithVariables2
{
    partial class frmWorkingWithVariables2
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
            this.btnIncrement = new System.Windows.Forms.Button();
            this.lblNumberDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(40, 34);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(101, 23);
            this.btnIncrement.TabIndex = 0;
            this.btnIncrement.Text = "Increment";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // lblNumberDisplay
            // 
            this.lblNumberDisplay.AutoSize = true;
            this.lblNumberDisplay.Location = new System.Drawing.Point(172, 40);
            this.lblNumberDisplay.Name = "lblNumberDisplay";
            this.lblNumberDisplay.Size = new System.Drawing.Size(0, 17);
            this.lblNumberDisplay.TabIndex = 1;
            // 
            // frmWorkingWithVariables2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 371);
            this.Controls.Add(this.lblNumberDisplay);
            this.Controls.Add(this.btnIncrement);
            this.Name = "frmWorkingWithVariables2";
            this.Text = "Increment My Label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Label lblNumberDisplay;
    }
}

