namespace Happy_Birthday___iterations
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.btnGreet = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select your birthdate";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 26);
            this.txtName.TabIndex = 2;
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.Location = new System.Drawing.Point(12, 84);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(273, 26);
            this.dtBirthdate.TabIndex = 3;
            // 
            // btnGreet
            // 
            this.btnGreet.Location = new System.Drawing.Point(210, 116);
            this.btnGreet.Name = "btnGreet";
            this.btnGreet.Size = new System.Drawing.Size(75, 29);
            this.btnGreet.TabIndex = 4;
            this.btnGreet.Text = "Greet me!";
            this.btnGreet.UseVisualStyleBackColor = true;
            this.btnGreet.Click += new System.EventHandler(this.greet);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(319, 9);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 20);
            this.lblOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 244);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnGreet);
            this.Controls.Add(this.dtBirthdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtBirthdate;
        private System.Windows.Forms.Button btnGreet;
        private System.Windows.Forms.Label lblOutput;
    }
}

