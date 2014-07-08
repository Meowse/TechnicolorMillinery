namespace BrushTeethWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.StartProcessbutton = new System.Windows.Forms.Button();
            this.HowToText = new System.Windows.Forms.Label();
            this.ShowProcedureButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Teeth Brushing for You";
            // 
            // StartProcessbutton
            // 
            this.StartProcessbutton.Location = new System.Drawing.Point(145, 36);
            this.StartProcessbutton.Name = "StartProcessbutton";
            this.StartProcessbutton.Size = new System.Drawing.Size(158, 23);
            this.StartProcessbutton.TabIndex = 1;
            this.StartProcessbutton.Text = "Press to start the process.";
            this.StartProcessbutton.UseVisualStyleBackColor = true;
            this.StartProcessbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // HowToText
            // 
            this.HowToText.AutoSize = true;
            this.HowToText.Location = new System.Drawing.Point(12, 62);
            this.HowToText.Name = "HowToText";
            this.HowToText.Size = new System.Drawing.Size(569, 247);
            this.HowToText.TabIndex = 2;
            this.HowToText.Text = resources.GetString("HowToText.Text");
            this.HowToText.Visible = false;
            this.HowToText.Click += new System.EventHandler(this.label2_Click);
            // 
            // ShowProcedureButton
            // 
            this.ShowProcedureButton.Location = new System.Drawing.Point(390, 114);
            this.ShowProcedureButton.Name = "ShowProcedureButton";
            this.ShowProcedureButton.Size = new System.Drawing.Size(156, 23);
            this.ShowProcedureButton.TabIndex = 3;
            this.ShowProcedureButton.Text = "Show this Procedure";
            this.ShowProcedureButton.UseVisualStyleBackColor = true;
            this.ShowProcedureButton.Visible = false;
            this.ShowProcedureButton.Click += new System.EventHandler(this.ShowProcedureButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show this Procedure";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowProcedureButton);
            this.Controls.Add(this.HowToText);
            this.Controls.Add(this.StartProcessbutton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartProcessbutton;
        private System.Windows.Forms.Label HowToText;
        private System.Windows.Forms.Button ShowProcedureButton;
        private System.Windows.Forms.Button button1;
    }
}

