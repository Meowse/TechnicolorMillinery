namespace BrushTeethWFA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.CloseMeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SayHelloButton = new System.Windows.Forms.Button();
            this.toolTipSayHello = new System.Windows.Forms.ToolTip(this.components);
            this.MyCheckBox = new System.Windows.Forms.CheckBox();
            this.MyMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.MyPictureBox = new System.Windows.Forms.PictureBox();
            this.SBToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MyWebBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click the button for instructions on how to brush your teeth";
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Location = new System.Drawing.Point(542, 65);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(83, 26);
            this.ClickMeButton.TabIndex = 1;
            this.ClickMeButton.Text = "Click Me";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButtonClicked);
            // 
            // CloseMeButton
            // 
            this.CloseMeButton.Location = new System.Drawing.Point(542, 123);
            this.CloseMeButton.Name = "CloseMeButton";
            this.CloseMeButton.Size = new System.Drawing.Size(83, 30);
            this.CloseMeButton.TabIndex = 2;
            this.CloseMeButton.Text = "Close me";
            this.CloseMeButton.UseVisualStyleBackColor = true;
            this.CloseMeButton.Click += new System.EventHandler(this.CloseMeButtonClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Or just go to http://www.wikihow.com/Brush-Your-Teeth for instructions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Click the button to say hello!";
            // 
            // SayHelloButton
            // 
            this.SayHelloButton.Location = new System.Drawing.Point(542, 19);
            this.SayHelloButton.Name = "SayHelloButton";
            this.SayHelloButton.Size = new System.Drawing.Size(96, 40);
            this.SayHelloButton.TabIndex = 5;
            this.SayHelloButton.Text = "Say Hello";
            this.toolTipSayHello.SetToolTip(this.SayHelloButton, "Clicking this button will popup a message box.");
            this.SayHelloButton.UseVisualStyleBackColor = true;
            this.SayHelloButton.Click += new System.EventHandler(this.SayHelloButtonClicked);
            // 
            // toolTipSayHello
            // 
            this.toolTipSayHello.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MyCheckBox
            // 
            this.MyCheckBox.AutoSize = true;
            this.MyCheckBox.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyCheckBox.Location = new System.Drawing.Point(227, 540);
            this.MyCheckBox.Name = "MyCheckBox";
            this.MyCheckBox.Size = new System.Drawing.Size(104, 21);
            this.MyCheckBox.TabIndex = 6;
            this.MyCheckBox.Text = "My Checkbox";
            this.MyCheckBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MyCheckBox.UseVisualStyleBackColor = true;
            this.MyCheckBox.Visible = false;
            // 
            // MyMonthCalendar
            // 
            this.MyMonthCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MyMonthCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MyMonthCalendar.Location = new System.Drawing.Point(18, 162);
            this.MyMonthCalendar.Name = "MyMonthCalendar";
            this.MyMonthCalendar.TabIndex = 7;
            // 
            // MyPictureBox
            // 
            this.MyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MyPictureBox.Image")));
            this.MyPictureBox.Location = new System.Drawing.Point(18, 381);
            this.MyPictureBox.Name = "MyPictureBox";
            this.MyPictureBox.Size = new System.Drawing.Size(203, 180);
            this.MyPictureBox.TabIndex = 8;
            this.MyPictureBox.TabStop = false;
            this.SBToolTip.SetToolTip(this.MyPictureBox, "Hey there! Whatcha doin\'?");
            // 
            // MyWebBrowser
            // 
            this.MyWebBrowser.Location = new System.Drawing.Point(328, 162);
            this.MyWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.MyWebBrowser.Name = "MyWebBrowser";
            this.MyWebBrowser.ScriptErrorsSuppressed = true;
            this.MyWebBrowser.Size = new System.Drawing.Size(674, 416);
            this.MyWebBrowser.TabIndex = 9;
            this.MyWebBrowser.Url = new System.Uri("http://www.boeing.com", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 605);
            this.Controls.Add(this.MyWebBrowser);
            this.Controls.Add(this.MyPictureBox);
            this.Controls.Add(this.MyMonthCalendar);
            this.Controls.Add(this.MyCheckBox);
            this.Controls.Add(this.SayHelloButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseMeButton);
            this.Controls.Add(this.ClickMeButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.Button CloseMeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SayHelloButton;
        private System.Windows.Forms.ToolTip toolTipSayHello;
        private System.Windows.Forms.CheckBox MyCheckBox;
        private System.Windows.Forms.MonthCalendar MyMonthCalendar;
        private System.Windows.Forms.PictureBox MyPictureBox;
        private System.Windows.Forms.ToolTip SBToolTip;
        private System.Windows.Forms.WebBrowser MyWebBrowser;
    }
}

