﻿namespace CalculatorBasicForm
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
            this.data_entry_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // data_entry_textbox
            // 
            this.data_entry_textbox.Location = new System.Drawing.Point(26, 21);
            this.data_entry_textbox.Name = "data_entry_textbox";
            this.data_entry_textbox.Size = new System.Drawing.Size(291, 20);
            this.data_entry_textbox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 538);
            this.Controls.Add(this.data_entry_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox data_entry_textbox;
    }
}

