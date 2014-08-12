namespace Calc
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
            this.buttonFor1 = new System.Windows.Forms.Button();
            this.buttonFor2 = new System.Windows.Forms.Button();
            this.buttonFor3 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.buttonForClear = new System.Windows.Forms.Button();
            this.key0 = new System.Windows.Forms.Button();
            this.keyDecimal = new System.Windows.Forms.Button();
            this.key4 = new System.Windows.Forms.Button();
            this.key5 = new System.Windows.Forms.Button();
            this.key6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFor1
            // 
            this.buttonFor1.Location = new System.Drawing.Point(13, 168);
            this.buttonFor1.Name = "buttonFor1";
            this.buttonFor1.Size = new System.Drawing.Size(30, 30);
            this.buttonFor1.TabIndex = 0;
            this.buttonFor1.Text = "1";
            this.buttonFor1.UseVisualStyleBackColor = true;
            this.buttonFor1.Click += new System.EventHandler(this.buttonFor1_Click);
            // 
            // buttonFor2
            // 
            this.buttonFor2.Location = new System.Drawing.Point(49, 168);
            this.buttonFor2.Name = "buttonFor2";
            this.buttonFor2.Size = new System.Drawing.Size(30, 30);
            this.buttonFor2.TabIndex = 1;
            this.buttonFor2.Text = "2";
            this.buttonFor2.UseVisualStyleBackColor = true;
            this.buttonFor2.Click += new System.EventHandler(this.buttonFor2_Click);
            // 
            // buttonFor3
            // 
            this.buttonFor3.Location = new System.Drawing.Point(85, 168);
            this.buttonFor3.Name = "buttonFor3";
            this.buttonFor3.Size = new System.Drawing.Size(30, 30);
            this.buttonFor3.TabIndex = 2;
            this.buttonFor3.Text = "3";
            this.buttonFor3.UseVisualStyleBackColor = true;
            this.buttonFor3.Click += new System.EventHandler(this.buttonFor3_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(13, 13);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(259, 22);
            this.display.TabIndex = 3;
            // 
            // buttonForClear
            // 
            this.buttonForClear.Location = new System.Drawing.Point(13, 65);
            this.buttonForClear.Name = "buttonForClear";
            this.buttonForClear.Size = new System.Drawing.Size(30, 30);
            this.buttonForClear.TabIndex = 4;
            this.buttonForClear.Text = "C";
            this.buttonForClear.UseVisualStyleBackColor = true;
            this.buttonForClear.Click += new System.EventHandler(this.buttonForClear_Click);
            // 
            // key0
            // 
            this.key0.Location = new System.Drawing.Point(13, 204);
            this.key0.Name = "key0";
            this.key0.Size = new System.Drawing.Size(66, 30);
            this.key0.TabIndex = 5;
            this.key0.Text = "0";
            this.key0.UseVisualStyleBackColor = true;
            this.key0.Click += new System.EventHandler(this.key0_Click);
            // 
            // keyDecimal
            // 
            this.keyDecimal.Location = new System.Drawing.Point(85, 204);
            this.keyDecimal.Name = "keyDecimal";
            this.keyDecimal.Size = new System.Drawing.Size(30, 30);
            this.keyDecimal.TabIndex = 6;
            this.keyDecimal.Text = ".";
            this.keyDecimal.UseVisualStyleBackColor = true;
            this.keyDecimal.Click += new System.EventHandler(this.keyDecimal_Click);
            // 
            // key4
            // 
            this.key4.Location = new System.Drawing.Point(13, 132);
            this.key4.Name = "key4";
            this.key4.Size = new System.Drawing.Size(30, 30);
            this.key4.TabIndex = 7;
            this.key4.Text = "4";
            this.key4.UseVisualStyleBackColor = true;
            this.key4.Click += new System.EventHandler(this.key4_Click);
            // 
            // key5
            // 
            this.key5.Location = new System.Drawing.Point(49, 132);
            this.key5.Name = "key5";
            this.key5.Size = new System.Drawing.Size(30, 30);
            this.key5.TabIndex = 8;
            this.key5.Text = "5";
            this.key5.UseVisualStyleBackColor = true;
            this.key5.Click += new System.EventHandler(this.key5_Click);
            // 
            // key6
            // 
            this.key6.Location = new System.Drawing.Point(85, 132);
            this.key6.Name = "key6";
            this.key6.Size = new System.Drawing.Size(30, 30);
            this.key6.TabIndex = 9;
            this.key6.Text = "6";
            this.key6.UseVisualStyleBackColor = true;
            this.key6.Click += new System.EventHandler(this.key6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.key6);
            this.Controls.Add(this.key5);
            this.Controls.Add(this.key4);
            this.Controls.Add(this.keyDecimal);
            this.Controls.Add(this.key0);
            this.Controls.Add(this.buttonForClear);
            this.Controls.Add(this.display);
            this.Controls.Add(this.buttonFor3);
            this.Controls.Add(this.buttonFor2);
            this.Controls.Add(this.buttonFor1);
            this.Name = "Form1";
            this.Text = "Calc!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFor1;
        private System.Windows.Forms.Button buttonFor2;
        private System.Windows.Forms.Button buttonFor3;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button buttonForClear;
        private System.Windows.Forms.Button key0;
        private System.Windows.Forms.Button keyDecimal;
        private System.Windows.Forms.Button key4;
        private System.Windows.Forms.Button key5;
        private System.Windows.Forms.Button key6;
    }
}

