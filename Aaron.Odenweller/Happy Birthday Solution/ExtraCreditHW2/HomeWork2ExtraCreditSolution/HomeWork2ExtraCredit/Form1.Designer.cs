namespace HomeWork2ExtraCredit
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNameInput = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblIntegerValue = new System.Windows.Forms.Label();
            this.lblInteger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(260, 86);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.Coral;
            this.lblOutput.Location = new System.Drawing.Point(205, 32);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(57, 20);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "label1";
            this.lblOutput.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Greet Me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNameInput
            // 
            this.lblNameInput.AutoSize = true;
            this.lblNameInput.Location = new System.Drawing.Point(205, 93);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.Size = new System.Drawing.Size(38, 13);
            this.lblNameInput.TabIndex = 3;
            this.lblNameInput.Text = "Name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Integer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblIntegerValue
            // 
            this.lblIntegerValue.AutoSize = true;
            this.lblIntegerValue.Location = new System.Drawing.Point(257, 165);
            this.lblIntegerValue.Name = "lblIntegerValue";
            this.lblIntegerValue.Size = new System.Drawing.Size(35, 13);
            this.lblIntegerValue.TabIndex = 5;
            this.lblIntegerValue.Text = "label1";
            // 
            // lblInteger
            // 
            this.lblInteger.AutoSize = true;
            this.lblInteger.Location = new System.Drawing.Point(205, 165);
            this.lblInteger.Name = "lblInteger";
            this.lblInteger.Size = new System.Drawing.Size(43, 13);
            this.lblInteger.TabIndex = 6;
            this.lblInteger.Text = "Integer:";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 359);
            this.Controls.Add(this.lblInteger);
            this.Controls.Add(this.lblIntegerValue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblNameInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Extra Credit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNameInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblIntegerValue;
        private System.Windows.Forms.Label lblInteger;
    }
}

