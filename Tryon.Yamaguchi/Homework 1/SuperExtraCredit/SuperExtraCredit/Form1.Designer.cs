namespace SuperExtraCredit
{
    partial class SuperExtraCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperExtraCredit));
            this.Title = new System.Windows.Forms.Label();
            this.displayMessage = new System.Windows.Forms.Button();
            this.lblSteps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(272, 17);
            this.Title.TabIndex = 0;
            this.Title.Text = "Hello Word with How to Brush Your Teeth!";
            // 
            // displayMessage
            // 
            this.displayMessage.Location = new System.Drawing.Point(949, 12);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(75, 23);
            this.displayMessage.TabIndex = 1;
            this.displayMessage.Text = "Display Message";
            this.displayMessage.UseVisualStyleBackColor = true;
            this.displayMessage.Click += new System.EventHandler(this.displayMessage_Click);
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(9, 38);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(1015, 442);
            this.lblSteps.TabIndex = 3;
            this.lblSteps.Text = resources.GetString("lblSteps.Text");
            // 
            // SuperExtraCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 428);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.displayMessage);
            this.Controls.Add(this.Title);
            this.Name = "SuperExtraCredit";
            this.Text = "Super Extra Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button displayMessage;
        private System.Windows.Forms.Label lblSteps;
    }
}

