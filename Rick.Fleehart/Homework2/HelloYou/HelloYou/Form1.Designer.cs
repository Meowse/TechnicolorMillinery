namespace HelloYou
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
            this.EnterName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelForName = new System.Windows.Forms.Label();
            this.Warninglabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterName
            // 
            this.EnterName.Location = new System.Drawing.Point(118, 75);
            this.EnterName.Name = "EnterName";
            this.EnterName.Size = new System.Drawing.Size(100, 20);
            this.EnterName.TabIndex = 0;
            this.EnterName.Text = "enter name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Greet Me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // labelForName
            // 
            this.labelForName.AutoSize = true;
            this.labelForName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForName.Location = new System.Drawing.Point(73, 137);
            this.labelForName.Name = "labelForName";
            this.labelForName.Size = new System.Drawing.Size(30, 24);
            this.labelForName.TabIndex = 3;
            this.labelForName.Text = "    ";
            // 
            // Warninglabel
            // 
            this.Warninglabel.AutoSize = true;
            this.Warninglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warninglabel.Location = new System.Drawing.Point(114, 98);
            this.Warninglabel.Name = "Warninglabel";
            this.Warninglabel.Size = new System.Drawing.Size(12, 16);
            this.Warninglabel.TabIndex = 4;
            this.Warninglabel.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 347);
            this.Controls.Add(this.Warninglabel);
            this.Controls.Add(this.labelForName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EnterName);
            this.Name = "Form1";
            this.Text = "Rick\'s Greet O\'matic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelForName;
        private System.Windows.Forms.Label Warninglabel;
    }
}

