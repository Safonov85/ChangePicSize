namespace ChangePicSize
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
            this.LoadPicButton = new System.Windows.Forms.Button();
            this.ResizePicturesButton = new System.Windows.Forms.Button();
            this.ResizeLevelCombobox = new System.Windows.Forms.ComboBox();
            this.ResizeToLabel = new System.Windows.Forms.Label();
            this.PicturesListbox = new System.Windows.Forms.ListBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.QualityTextBox = new System.Windows.Forms.TextBox();
            this.QualityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadPicButton
            // 
            this.LoadPicButton.Location = new System.Drawing.Point(28, 29);
            this.LoadPicButton.Name = "LoadPicButton";
            this.LoadPicButton.Size = new System.Drawing.Size(164, 81);
            this.LoadPicButton.TabIndex = 0;
            this.LoadPicButton.Text = "Load Picture(s)";
            this.LoadPicButton.UseVisualStyleBackColor = true;
            this.LoadPicButton.Click += new System.EventHandler(this.LoadPicButton_Click);
            // 
            // ResizePicturesButton
            // 
            this.ResizePicturesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ResizePicturesButton.Location = new System.Drawing.Point(28, 129);
            this.ResizePicturesButton.Name = "ResizePicturesButton";
            this.ResizePicturesButton.Size = new System.Drawing.Size(164, 100);
            this.ResizePicturesButton.TabIndex = 1;
            this.ResizePicturesButton.Text = "RESIZE";
            this.ResizePicturesButton.UseVisualStyleBackColor = false;
            this.ResizePicturesButton.Click += new System.EventHandler(this.ResizePicturesButton_Click);
            // 
            // ResizeLevelCombobox
            // 
            this.ResizeLevelCombobox.FormattingEnabled = true;
            this.ResizeLevelCombobox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.ResizeLevelCombobox.Location = new System.Drawing.Point(16, 297);
            this.ResizeLevelCombobox.Name = "ResizeLevelCombobox";
            this.ResizeLevelCombobox.Size = new System.Drawing.Size(164, 28);
            this.ResizeLevelCombobox.TabIndex = 1;
            // 
            // ResizeToLabel
            // 
            this.ResizeToLabel.AutoSize = true;
            this.ResizeToLabel.Location = new System.Drawing.Point(12, 342);
            this.ResizeToLabel.Name = "ResizeToLabel";
            this.ResizeToLabel.Size = new System.Drawing.Size(84, 20);
            this.ResizeToLabel.TabIndex = 3;
            this.ResizeToLabel.Text = "Resize To:";
            // 
            // PicturesListbox
            // 
            this.PicturesListbox.FormattingEnabled = true;
            this.PicturesListbox.ItemHeight = 20;
            this.PicturesListbox.Location = new System.Drawing.Point(270, 41);
            this.PicturesListbox.Name = "PicturesListbox";
            this.PicturesListbox.Size = new System.Drawing.Size(420, 284);
            this.PicturesListbox.TabIndex = 4;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.MistyRose;
            this.CancelButton.Location = new System.Drawing.Point(285, 365);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(227, 108);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "CANCEL (not working yet)";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.SystemColors.Menu;
            this.AboutButton.Location = new System.Drawing.Point(12, 466);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(80, 48);
            this.AboutButton.TabIndex = 6;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // QualityTextBox
            // 
            this.QualityTextBox.Location = new System.Drawing.Point(98, 250);
            this.QualityTextBox.Name = "QualityTextBox";
            this.QualityTextBox.Size = new System.Drawing.Size(68, 26);
            this.QualityTextBox.TabIndex = 7;
            this.QualityTextBox.Text = "100";
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.Location = new System.Drawing.Point(31, 253);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(61, 20);
            this.QualityLabel.TabIndex = 8;
            this.QualityLabel.Text = "Quality:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 526);
            this.Controls.Add(this.QualityLabel);
            this.Controls.Add(this.QualityTextBox);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PicturesListbox);
            this.Controls.Add(this.ResizeToLabel);
            this.Controls.Add(this.ResizeLevelCombobox);
            this.Controls.Add(this.ResizePicturesButton);
            this.Controls.Add(this.LoadPicButton);
            this.Name = "Form1";
            this.Text = "Re-size Picture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadPicButton;
        private System.Windows.Forms.Button ResizePicturesButton;
        private System.Windows.Forms.ComboBox ResizeLevelCombobox;
        private System.Windows.Forms.Label ResizeToLabel;
        private System.Windows.Forms.ListBox PicturesListbox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.TextBox QualityTextBox;
        private System.Windows.Forms.Label QualityLabel;
    }
}

