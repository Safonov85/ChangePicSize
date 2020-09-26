namespace ChangePicSize
{
    partial class ChangePicMain
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
            this.ClearListButton = new System.Windows.Forms.Button();
            this.rotateRightCheckBox = new System.Windows.Forms.CheckBox();
            this.ChangePicTabControlPage = new System.Windows.Forms.TabControl();
            this.ChangePicDragNdrop = new System.Windows.Forms.TabPage();
            this.DragNdropLabel = new System.Windows.Forms.Label();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.LiveUpdateProgressBar = new System.Windows.Forms.ProgressBar();
            this.DropSignLabel = new System.Windows.Forms.Label();
            this.ChangePicOldStylePage = new System.Windows.Forms.TabPage();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.PathSettingsTextBox = new System.Windows.Forms.TextBox();
            this.QualitySettingsTextBox = new System.Windows.Forms.TextBox();
            this.ResSettingsTextBox = new System.Windows.Forms.TextBox();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.SavePathSettingsLabel = new System.Windows.Forms.Label();
            this.FileTypeSettingsCombo = new System.Windows.Forms.ComboBox();
            this.QualitySettingsLabel = new System.Windows.Forms.Label();
            this.ResolutionSettingsLabel = new System.Windows.Forms.Label();
            this.Rotate90SettingsCheckB = new System.Windows.Forms.CheckBox();
            this.SourceCodeLabel = new System.Windows.Forms.Label();
            this.ChangePicTabControlPage.SuspendLayout();
            this.ChangePicDragNdrop.SuspendLayout();
            this.ChangePicOldStylePage.SuspendLayout();
            this.SettingsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadPicButton
            // 
            this.LoadPicButton.Location = new System.Drawing.Point(32, 19);
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
            this.ResizePicturesButton.Location = new System.Drawing.Point(249, 19);
            this.ResizePicturesButton.Name = "ResizePicturesButton";
            this.ResizePicturesButton.Size = new System.Drawing.Size(164, 81);
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
            this.ResizeLevelCombobox.Location = new System.Drawing.Point(496, 208);
            this.ResizeLevelCombobox.Name = "ResizeLevelCombobox";
            this.ResizeLevelCombobox.Size = new System.Drawing.Size(164, 28);
            this.ResizeLevelCombobox.TabIndex = 1;
            // 
            // ResizeToLabel
            // 
            this.ResizeToLabel.AutoSize = true;
            this.ResizeToLabel.Location = new System.Drawing.Point(454, 117);
            this.ResizeToLabel.Name = "ResizeToLabel";
            this.ResizeToLabel.Size = new System.Drawing.Size(84, 20);
            this.ResizeToLabel.TabIndex = 3;
            this.ResizeToLabel.Text = "Resize To:";
            // 
            // PicturesListbox
            // 
            this.PicturesListbox.FormattingEnabled = true;
            this.PicturesListbox.ItemHeight = 20;
            this.PicturesListbox.Location = new System.Drawing.Point(19, 117);
            this.PicturesListbox.Name = "PicturesListbox";
            this.PicturesListbox.Size = new System.Drawing.Size(420, 284);
            this.PicturesListbox.TabIndex = 4;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.MistyRose;
            this.CancelButton.Location = new System.Drawing.Point(527, 17);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(118, 85);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "CANCEL (not working yet)";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.SystemColors.Menu;
            this.AboutButton.Location = new System.Drawing.Point(615, 458);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(80, 48);
            this.AboutButton.TabIndex = 6;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // QualityTextBox
            // 
            this.QualityTextBox.Location = new System.Drawing.Point(559, 170);
            this.QualityTextBox.Name = "QualityTextBox";
            this.QualityTextBox.Size = new System.Drawing.Size(68, 26);
            this.QualityTextBox.TabIndex = 7;
            this.QualityTextBox.Text = "100";
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.Location = new System.Drawing.Point(492, 173);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(61, 20);
            this.QualityLabel.TabIndex = 8;
            this.QualityLabel.Text = "Quality:";
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(73, 425);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(285, 64);
            this.ClearListButton.TabIndex = 9;
            this.ClearListButton.Text = "CLEAR LIST";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // rotateRightCheckBox
            // 
            this.rotateRightCheckBox.AutoSize = true;
            this.rotateRightCheckBox.Checked = true;
            this.rotateRightCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rotateRightCheckBox.Location = new System.Drawing.Point(458, 268);
            this.rotateRightCheckBox.Name = "rotateRightCheckBox";
            this.rotateRightCheckBox.Size = new System.Drawing.Size(111, 24);
            this.rotateRightCheckBox.TabIndex = 10;
            this.rotateRightCheckBox.Text = "Rotate 90°";
            this.rotateRightCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChangePicTabControlPage
            // 
            this.ChangePicTabControlPage.Controls.Add(this.ChangePicDragNdrop);
            this.ChangePicTabControlPage.Controls.Add(this.ChangePicOldStylePage);
            this.ChangePicTabControlPage.Controls.Add(this.SettingsTabPage);
            this.ChangePicTabControlPage.Location = new System.Drawing.Point(0, 0);
            this.ChangePicTabControlPage.Name = "ChangePicTabControlPage";
            this.ChangePicTabControlPage.SelectedIndex = 0;
            this.ChangePicTabControlPage.Size = new System.Drawing.Size(737, 573);
            this.ChangePicTabControlPage.TabIndex = 11;
            // 
            // ChangePicDragNdrop
            // 
            this.ChangePicDragNdrop.AllowDrop = true;
            this.ChangePicDragNdrop.BackColor = System.Drawing.Color.DimGray;
            this.ChangePicDragNdrop.Controls.Add(this.DragNdropLabel);
            this.ChangePicDragNdrop.Controls.Add(this.ProgressLabel);
            this.ChangePicDragNdrop.Controls.Add(this.LiveUpdateProgressBar);
            this.ChangePicDragNdrop.Controls.Add(this.DropSignLabel);
            this.ChangePicDragNdrop.Location = new System.Drawing.Point(4, 29);
            this.ChangePicDragNdrop.Name = "ChangePicDragNdrop";
            this.ChangePicDragNdrop.Padding = new System.Windows.Forms.Padding(3);
            this.ChangePicDragNdrop.Size = new System.Drawing.Size(729, 540);
            this.ChangePicDragNdrop.TabIndex = 0;
            this.ChangePicDragNdrop.Text = "Drag \'n Drop";
            this.ChangePicDragNdrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChangePicDragNdrop_DragDrop);
            this.ChangePicDragNdrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChangePicDragNdrop_DragEnter);
            // 
            // DragNdropLabel
            // 
            this.DragNdropLabel.AutoSize = true;
            this.DragNdropLabel.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragNdropLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DragNdropLabel.Location = new System.Drawing.Point(214, 253);
            this.DragNdropLabel.Name = "DragNdropLabel";
            this.DragNdropLabel.Size = new System.Drawing.Size(298, 45);
            this.DragNdropLabel.TabIndex = 0;
            this.DragNdropLabel.Text = "--- Drag \'n Drop ---";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProgressLabel.Location = new System.Drawing.Point(295, 486);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(139, 20);
            this.ProgressLabel.TabIndex = 3;
            this.ProgressLabel.Text = "Loading Pictures...";
            this.ProgressLabel.Visible = false;
            // 
            // LiveUpdateProgressBar
            // 
            this.LiveUpdateProgressBar.Location = new System.Drawing.Point(85, 439);
            this.LiveUpdateProgressBar.Name = "LiveUpdateProgressBar";
            this.LiveUpdateProgressBar.Size = new System.Drawing.Size(562, 23);
            this.LiveUpdateProgressBar.TabIndex = 2;
            this.LiveUpdateProgressBar.Visible = false;
            // 
            // DropSignLabel
            // 
            this.DropSignLabel.AutoSize = true;
            this.DropSignLabel.BackColor = System.Drawing.Color.Transparent;
            this.DropSignLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropSignLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DropSignLabel.Location = new System.Drawing.Point(18, 182);
            this.DropSignLabel.Name = "DropSignLabel";
            this.DropSignLabel.Size = new System.Drawing.Size(705, 168);
            this.DropSignLabel.TabIndex = 1;
            this.DropSignLabel.Text = "[             ]";
            this.DropSignLabel.Click += new System.EventHandler(this.DropSignLabel_Click);
            // 
            // ChangePicOldStylePage
            // 
            this.ChangePicOldStylePage.Controls.Add(this.PicturesListbox);
            this.ChangePicOldStylePage.Controls.Add(this.rotateRightCheckBox);
            this.ChangePicOldStylePage.Controls.Add(this.ResizeLevelCombobox);
            this.ChangePicOldStylePage.Controls.Add(this.QualityTextBox);
            this.ChangePicOldStylePage.Controls.Add(this.LoadPicButton);
            this.ChangePicOldStylePage.Controls.Add(this.QualityLabel);
            this.ChangePicOldStylePage.Controls.Add(this.CancelButton);
            this.ChangePicOldStylePage.Controls.Add(this.ResizeToLabel);
            this.ChangePicOldStylePage.Controls.Add(this.ClearListButton);
            this.ChangePicOldStylePage.Controls.Add(this.ResizePicturesButton);
            this.ChangePicOldStylePage.Controls.Add(this.AboutButton);
            this.ChangePicOldStylePage.Location = new System.Drawing.Point(4, 29);
            this.ChangePicOldStylePage.Name = "ChangePicOldStylePage";
            this.ChangePicOldStylePage.Padding = new System.Windows.Forms.Padding(3);
            this.ChangePicOldStylePage.Size = new System.Drawing.Size(729, 540);
            this.ChangePicOldStylePage.TabIndex = 1;
            this.ChangePicOldStylePage.Text = "Manual Load \'n Save";
            this.ChangePicOldStylePage.UseVisualStyleBackColor = true;
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.BackColor = System.Drawing.Color.Gainsboro;
            this.SettingsTabPage.Controls.Add(this.SourceCodeLabel);
            this.SettingsTabPage.Controls.Add(this.PathSettingsTextBox);
            this.SettingsTabPage.Controls.Add(this.QualitySettingsTextBox);
            this.SettingsTabPage.Controls.Add(this.ResSettingsTextBox);
            this.SettingsTabPage.Controls.Add(this.SaveSettingsButton);
            this.SettingsTabPage.Controls.Add(this.SavePathSettingsLabel);
            this.SettingsTabPage.Controls.Add(this.FileTypeSettingsCombo);
            this.SettingsTabPage.Controls.Add(this.QualitySettingsLabel);
            this.SettingsTabPage.Controls.Add(this.ResolutionSettingsLabel);
            this.SettingsTabPage.Controls.Add(this.Rotate90SettingsCheckB);
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 29);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(729, 540);
            this.SettingsTabPage.TabIndex = 2;
            this.SettingsTabPage.Text = "Settings";
            // 
            // PathSettingsTextBox
            // 
            this.PathSettingsTextBox.Location = new System.Drawing.Point(233, 277);
            this.PathSettingsTextBox.Name = "PathSettingsTextBox";
            this.PathSettingsTextBox.Size = new System.Drawing.Size(359, 26);
            this.PathSettingsTextBox.TabIndex = 12;
            this.PathSettingsTextBox.TextChanged += new System.EventHandler(this.PathSettingsTextBox_TextChanged);
            // 
            // QualitySettingsTextBox
            // 
            this.QualitySettingsTextBox.Location = new System.Drawing.Point(208, 150);
            this.QualitySettingsTextBox.Name = "QualitySettingsTextBox";
            this.QualitySettingsTextBox.Size = new System.Drawing.Size(100, 26);
            this.QualitySettingsTextBox.TabIndex = 11;
            this.QualitySettingsTextBox.TextChanged += new System.EventHandler(this.QualitySettingsTextBox_TextChanged);
            // 
            // ResSettingsTextBox
            // 
            this.ResSettingsTextBox.Location = new System.Drawing.Point(189, 107);
            this.ResSettingsTextBox.Name = "ResSettingsTextBox";
            this.ResSettingsTextBox.Size = new System.Drawing.Size(100, 26);
            this.ResSettingsTextBox.TabIndex = 10;
            this.ResSettingsTextBox.TextChanged += new System.EventHandler(this.ResSettingsTextBox_TextChanged);
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaveSettingsButton.Location = new System.Drawing.Point(140, 363);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(162, 76);
            this.SaveSettingsButton.TabIndex = 9;
            this.SaveSettingsButton.Text = "SAVE";
            this.SaveSettingsButton.UseVisualStyleBackColor = false;
            // 
            // SavePathSettingsLabel
            // 
            this.SavePathSettingsLabel.AutoSize = true;
            this.SavePathSettingsLabel.Location = new System.Drawing.Point(145, 280);
            this.SavePathSettingsLabel.Name = "SavePathSettingsLabel";
            this.SavePathSettingsLabel.Size = new System.Drawing.Size(82, 20);
            this.SavePathSettingsLabel.TabIndex = 8;
            this.SavePathSettingsLabel.Text = "Save Path";
            // 
            // FileTypeSettingsCombo
            // 
            this.FileTypeSettingsCombo.FormattingEnabled = true;
            this.FileTypeSettingsCombo.Items.AddRange(new object[] {
            ".jpg",
            ".png",
            ".gif",
            "."});
            this.FileTypeSettingsCombo.Location = new System.Drawing.Point(149, 189);
            this.FileTypeSettingsCombo.Name = "FileTypeSettingsCombo";
            this.FileTypeSettingsCombo.Size = new System.Drawing.Size(121, 28);
            this.FileTypeSettingsCombo.TabIndex = 7;
            // 
            // QualitySettingsLabel
            // 
            this.QualitySettingsLabel.AutoSize = true;
            this.QualitySettingsLabel.Location = new System.Drawing.Point(145, 150);
            this.QualitySettingsLabel.Name = "QualitySettingsLabel";
            this.QualitySettingsLabel.Size = new System.Drawing.Size(57, 20);
            this.QualitySettingsLabel.TabIndex = 6;
            this.QualitySettingsLabel.Text = "Quality";
            // 
            // ResolutionSettingsLabel
            // 
            this.ResolutionSettingsLabel.AutoSize = true;
            this.ResolutionSettingsLabel.Location = new System.Drawing.Point(145, 110);
            this.ResolutionSettingsLabel.Name = "ResolutionSettingsLabel";
            this.ResolutionSettingsLabel.Size = new System.Drawing.Size(38, 20);
            this.ResolutionSettingsLabel.TabIndex = 5;
            this.ResolutionSettingsLabel.Text = "Res";
            // 
            // Rotate90SettingsCheckB
            // 
            this.Rotate90SettingsCheckB.AutoSize = true;
            this.Rotate90SettingsCheckB.Location = new System.Drawing.Point(149, 239);
            this.Rotate90SettingsCheckB.Name = "Rotate90SettingsCheckB";
            this.Rotate90SettingsCheckB.Size = new System.Drawing.Size(106, 24);
            this.Rotate90SettingsCheckB.TabIndex = 3;
            this.Rotate90SettingsCheckB.Text = "Rotate 90";
            this.Rotate90SettingsCheckB.UseVisualStyleBackColor = true;
            // 
            // SourceCodeLabel
            // 
            this.SourceCodeLabel.AutoSize = true;
            this.SourceCodeLabel.BackColor = System.Drawing.Color.DimGray;
            this.SourceCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceCodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SourceCodeLabel.Location = new System.Drawing.Point(23, 490);
            this.SourceCodeLabel.Name = "SourceCodeLabel";
            this.SourceCodeLabel.Size = new System.Drawing.Size(648, 29);
            this.SourceCodeLabel.TabIndex = 13;
            this.SourceCodeLabel.Text = "Source Code: https://github.com/Safonov85/ChangePicSize";
            // 
            // ChangePicMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 588);
            this.Controls.Add(this.ChangePicTabControlPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangePicMain";
            this.Text = "Re-size Picture";
            this.ChangePicTabControlPage.ResumeLayout(false);
            this.ChangePicDragNdrop.ResumeLayout(false);
            this.ChangePicDragNdrop.PerformLayout();
            this.ChangePicOldStylePage.ResumeLayout(false);
            this.ChangePicOldStylePage.PerformLayout();
            this.SettingsTabPage.ResumeLayout(false);
            this.SettingsTabPage.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.CheckBox rotateRightCheckBox;
        private System.Windows.Forms.TabControl ChangePicTabControlPage;
        private System.Windows.Forms.TabPage ChangePicDragNdrop;
        private System.Windows.Forms.TabPage ChangePicOldStylePage;
        private System.Windows.Forms.Label DragNdropLabel;
        private System.Windows.Forms.Label DropSignLabel;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.ProgressBar LiveUpdateProgressBar;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.CheckBox Rotate90SettingsCheckB;
        private System.Windows.Forms.Label ResolutionSettingsLabel;
        private System.Windows.Forms.Label QualitySettingsLabel;
        private System.Windows.Forms.ComboBox FileTypeSettingsCombo;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.Label SavePathSettingsLabel;
        private System.Windows.Forms.TextBox PathSettingsTextBox;
        private System.Windows.Forms.TextBox QualitySettingsTextBox;
        private System.Windows.Forms.TextBox ResSettingsTextBox;
        private System.Windows.Forms.Label SourceCodeLabel;
    }
}

