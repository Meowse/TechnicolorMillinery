namespace Variables2
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
            this.addtobucket = new System.Windows.Forms.Button();
            this.showbucket = new System.Windows.Forms.Label();
            this.emptythebucket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addtobucket
            // 
            this.addtobucket.Location = new System.Drawing.Point(60, 60);
            this.addtobucket.Name = "addtobucket";
            this.addtobucket.Size = new System.Drawing.Size(161, 36);
            this.addtobucket.TabIndex = 0;
            this.addtobucket.Text = "Add 1 to the bucket!";
            this.addtobucket.UseVisualStyleBackColor = true;
            this.addtobucket.Click += new System.EventHandler(this.addone);
            // 
            // showbucket
            // 
            this.showbucket.AutoSize = true;
            this.showbucket.Location = new System.Drawing.Point(135, 131);
            this.showbucket.Name = "showbucket";
            this.showbucket.Size = new System.Drawing.Size(13, 13);
            this.showbucket.TabIndex = 1;
            this.showbucket.Text = "0";
            // 
            // emptythebucket
            // 
            this.emptythebucket.Location = new System.Drawing.Point(60, 175);
            this.emptythebucket.Name = "emptythebucket";
            this.emptythebucket.Size = new System.Drawing.Size(161, 25);
            this.emptythebucket.TabIndex = 2;
            this.emptythebucket.Text = "Empty the bucket!";
            this.emptythebucket.UseVisualStyleBackColor = true;
            this.emptythebucket.Click += new System.EventHandler(this.dumpbucket);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.emptythebucket);
            this.Controls.Add(this.showbucket);
            this.Controls.Add(this.addtobucket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addtobucket;
        private System.Windows.Forms.Label showbucket;
        private System.Windows.Forms.Button emptythebucket;
    }
}

