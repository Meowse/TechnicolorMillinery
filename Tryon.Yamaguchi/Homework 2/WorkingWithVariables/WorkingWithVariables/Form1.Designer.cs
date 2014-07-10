namespace WorkingWithVariables
{
    partial class frmWorkingWithVariables
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
            this.lblGreetingMessage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGreet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGreetingMessage
            // 
            this.lblGreetingMessage.AutoSize = true;
            this.lblGreetingMessage.Location = new System.Drawing.Point(326, 32);
            this.lblGreetingMessage.Name = "lblGreetingMessage";
            this.lblGreetingMessage.Size = new System.Drawing.Size(0, 17);
            this.lblGreetingMessage.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(186, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // btnGreet
            // 
            this.btnGreet.Location = new System.Drawing.Point(186, 65);
            this.btnGreet.Name = "btnGreet";
            this.btnGreet.Size = new System.Drawing.Size(100, 23);
            this.btnGreet.TabIndex = 3;
            this.btnGreet.Text = "Greet Me!";
            this.btnGreet.UseVisualStyleBackColor = true;
            this.btnGreet.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmWorkingWithVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 376);
            this.Controls.Add(this.btnGreet);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGreetingMessage);
            this.Controls.Add(this.label1);
            this.Name = "frmWorkingWithVariables";
            this.Text = "Greeting the User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGreetingMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGreet;
    }
}

