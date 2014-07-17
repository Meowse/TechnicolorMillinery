namespace HelloWorldForm
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
            this.helloworld_button = new System.Windows.Forms.Button();
            this.howtobrushteeth_button = new System.Windows.Forms.Button();
            this.helloBridget = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.retrieveButton = new System.Windows.Forms.Button();
            this.nameLabelTwo = new System.Windows.Forms.Label();
            this.addOne = new System.Windows.Forms.Button();
            this.colorChanger_checkbox = new System.Windows.Forms.CheckBox();
            this.colorChanger_Label = new System.Windows.Forms.Label();
            this.colorChanger_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloworld_button
            // 
            this.helloworld_button.Location = new System.Drawing.Point(12, 337);
            this.helloworld_button.Name = "helloworld_button";
            this.helloworld_button.Size = new System.Drawing.Size(75, 23);
            this.helloworld_button.TabIndex = 0;
            this.helloworld_button.Text = "Hello World";
            this.helloworld_button.UseVisualStyleBackColor = true;
            this.helloworld_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // howtobrushteeth_button
            // 
            this.howtobrushteeth_button.Location = new System.Drawing.Point(12, 377);
            this.howtobrushteeth_button.Name = "howtobrushteeth_button";
            this.howtobrushteeth_button.Size = new System.Drawing.Size(126, 23);
            this.howtobrushteeth_button.TabIndex = 1;
            this.howtobrushteeth_button.Text = "How to Brush your teeth";
            this.howtobrushteeth_button.UseVisualStyleBackColor = true;
            this.howtobrushteeth_button.Click += new System.EventHandler(this.howtobrushteeth_button_Click);
            // 
            // helloBridget
            // 
            this.helloBridget.Location = new System.Drawing.Point(12, 406);
            this.helloBridget.Name = "helloBridget";
            this.helloBridget.Size = new System.Drawing.Size(75, 23);
            this.helloBridget.TabIndex = 2;
            this.helloBridget.Text = "Hello Bridget";
            this.helloBridget.UseVisualStyleBackColor = true;
            this.helloBridget.Click += new System.EventHandler(this.helloBridget_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(37, 175);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(40, 191);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(251, 20);
            this.nameText.TabIndex = 4;
            // 
            // retrieveButton
            // 
            this.retrieveButton.Location = new System.Drawing.Point(40, 212);
            this.retrieveButton.Name = "retrieveButton";
            this.retrieveButton.Size = new System.Drawing.Size(105, 23);
            this.retrieveButton.TabIndex = 5;
            this.retrieveButton.Text = "Greet Me!";
            this.retrieveButton.UseVisualStyleBackColor = true;
            this.retrieveButton.Click += new System.EventHandler(this.retrieveButton_Click);
            // 
            // nameLabelTwo
            // 
            this.nameLabelTwo.AutoSize = true;
            this.nameLabelTwo.Location = new System.Drawing.Point(37, 260);
            this.nameLabelTwo.Name = "nameLabelTwo";
            this.nameLabelTwo.Size = new System.Drawing.Size(13, 13);
            this.nameLabelTwo.TabIndex = 6;
            this.nameLabelTwo.Text = "0";
            // 
            // addOne
            // 
            this.addOne.Location = new System.Drawing.Point(196, 255);
            this.addOne.Name = "addOne";
            this.addOne.Size = new System.Drawing.Size(75, 23);
            this.addOne.TabIndex = 7;
            this.addOne.Text = "Add 1";
            this.addOne.UseVisualStyleBackColor = true;
            this.addOne.Click += new System.EventHandler(this.addOne_Click);
            // 
            // colorChanger_checkbox
            // 
            this.colorChanger_checkbox.AutoSize = true;
            this.colorChanger_checkbox.Location = new System.Drawing.Point(703, 193);
            this.colorChanger_checkbox.Name = "colorChanger_checkbox";
            this.colorChanger_checkbox.Size = new System.Drawing.Size(132, 17);
            this.colorChanger_checkbox.TabIndex = 9;
            this.colorChanger_checkbox.Text = "Enable color changing";
            this.colorChanger_checkbox.UseVisualStyleBackColor = true;
            // 
            // colorChanger_Label
            // 
            this.colorChanger_Label.AutoSize = true;
            this.colorChanger_Label.Location = new System.Drawing.Point(548, 194);
            this.colorChanger_Label.Name = "colorChanger_Label";
            this.colorChanger_Label.Size = new System.Drawing.Size(74, 13);
            this.colorChanger_Label.TabIndex = 11;
            this.colorChanger_Label.Text = "Color Changer";
            // 
            // colorChanger_button
            // 
            this.colorChanger_button.Location = new System.Drawing.Point(592, 250);
            this.colorChanger_button.Name = "colorChanger_button";
            this.colorChanger_button.Size = new System.Drawing.Size(213, 23);
            this.colorChanger_button.TabIndex = 12;
            this.colorChanger_button.Text = "Change the color if the box is checked";
            this.colorChanger_button.UseVisualStyleBackColor = true;
            this.colorChanger_button.Click += new System.EventHandler(this.colorChanger_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 584);
            this.Controls.Add(this.colorChanger_button);
            this.Controls.Add(this.colorChanger_Label);
            this.Controls.Add(this.colorChanger_checkbox);
            this.Controls.Add(this.addOne);
            this.Controls.Add(this.nameLabelTwo);
            this.Controls.Add(this.retrieveButton);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.helloBridget);
            this.Controls.Add(this.howtobrushteeth_button);
            this.Controls.Add(this.helloworld_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button helloworld_button;
        private System.Windows.Forms.Button howtobrushteeth_button;
        private System.Windows.Forms.Button helloBridget;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button retrieveButton;
        private System.Windows.Forms.Label nameLabelTwo;
        private System.Windows.Forms.Button addOne;
        private System.Windows.Forms.CheckBox colorChanger_checkbox;
        private System.Windows.Forms.Label colorChanger_Label;
        private System.Windows.Forms.Button colorChanger_button;
    }
}

