namespace graph_folder_crawling
{
    partial class mainWindow
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
            this.Title = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.startingDirectoryLabel = new System.Windows.Forms.Label();
            this.startingDirectory = new System.Windows.Forms.Label();
            this.inputFileLabel = new System.Windows.Forms.Label();
            this.inputFileTextField = new System.Windows.Forms.TextBox();
            this.findingMethodLabel = new System.Windows.Forms.Label();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.clearButton = new graph_folder_crawling.Custom_controls.CustomButton();
            this.occurenceCheckBox = new graph_folder_crawling.Custom_controls.CustomCheckBox();
            this.radioButtonDFS = new graph_folder_crawling.Custom_controls.CustomRadioButton();
            this.chooseFolderButton = new graph_folder_crawling.Custom_controls.CustomButton();
            this.radioButtonBFS = new graph_folder_crawling.Custom_controls.CustomRadioButton();
            this.searchButton = new graph_folder_crawling.Custom_controls.CustomButton();
            this.Authors = new System.Windows.Forms.Label();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.GroupName = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.Line = new System.Windows.Forms.Label();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.timeSpent = new System.Windows.Forms.Label();
            this.fileLocationLink = new System.Windows.Forms.LinkLabel();
            this.fileLocationLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.InputPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Control;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(668, 85);
            this.Title.TabIndex = 0;
            this.Title.Text = "Folder Crawler";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.inputLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.inputLabel.Location = new System.Drawing.Point(22, 104);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(82, 36);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Input";
            // 
            // startingDirectoryLabel
            // 
            this.startingDirectoryLabel.AutoSize = true;
            this.startingDirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startingDirectoryLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.startingDirectoryLabel.Location = new System.Drawing.Point(26, 150);
            this.startingDirectoryLabel.Name = "startingDirectoryLabel";
            this.startingDirectoryLabel.Size = new System.Drawing.Size(185, 20);
            this.startingDirectoryLabel.TabIndex = 3;
            this.startingDirectoryLabel.Text = "Choose starting directory";
            // 
            // startingDirectory
            // 
            this.startingDirectory.AutoSize = true;
            this.startingDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.startingDirectory.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.startingDirectory.Location = new System.Drawing.Point(27, 207);
            this.startingDirectory.MaximumSize = new System.Drawing.Size(280, 0);
            this.startingDirectory.Name = "startingDirectory";
            this.startingDirectory.Size = new System.Drawing.Size(91, 15);
            this.startingDirectory.TabIndex = 5;
            this.startingDirectory.Text = "No File Chosen";
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.AutoSize = true;
            this.inputFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputFileLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.inputFileLabel.Location = new System.Drawing.Point(24, 255);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(121, 20);
            this.inputFileLabel.TabIndex = 6;
            this.inputFileLabel.Text = "Input File Name";
            // 
            // inputFileTextField
            // 
            this.inputFileTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.inputFileTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputFileTextField.ForeColor = System.Drawing.SystemColors.Window;
            this.inputFileTextField.Location = new System.Drawing.Point(28, 280);
            this.inputFileTextField.Name = "inputFileTextField";
            this.inputFileTextField.Size = new System.Drawing.Size(253, 23);
            this.inputFileTextField.TabIndex = 7;
            this.inputFileTextField.Text = "e.g. \"word.pdf\"";
            this.inputFileTextField.Enter += new System.EventHandler(this.inputFileTextField_Enter);
            this.inputFileTextField.Leave += new System.EventHandler(this.inputFileTextField_Leave);
            // 
            // findingMethodLabel
            // 
            this.findingMethodLabel.AutoSize = true;
            this.findingMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.findingMethodLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.findingMethodLabel.Location = new System.Drawing.Point(24, 354);
            this.findingMethodLabel.Name = "findingMethodLabel";
            this.findingMethodLabel.Size = new System.Drawing.Size(179, 20);
            this.findingMethodLabel.TabIndex = 8;
            this.findingMethodLabel.Text = "Input Metode Pencarian";
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.InputPanel.Controls.Add(this.clearButton);
            this.InputPanel.Controls.Add(this.occurenceCheckBox);
            this.InputPanel.Controls.Add(this.radioButtonDFS);
            this.InputPanel.Controls.Add(this.chooseFolderButton);
            this.InputPanel.Controls.Add(this.radioButtonBFS);
            this.InputPanel.Controls.Add(this.searchButton);
            this.InputPanel.Controls.Add(this.Authors);
            this.InputPanel.Controls.Add(this.logoPanel);
            this.InputPanel.Controls.Add(this.inputLabel);
            this.InputPanel.Controls.Add(this.startingDirectoryLabel);
            this.InputPanel.Controls.Add(this.startingDirectory);
            this.InputPanel.Controls.Add(this.findingMethodLabel);
            this.InputPanel.Controls.Add(this.inputFileLabel);
            this.InputPanel.Controls.Add(this.inputFileTextField);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputPanel.Location = new System.Drawing.Point(0, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(316, 696);
            this.InputPanel.TabIndex = 13;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.OrangeRed;
            this.clearButton.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.clearButton.BorderColor = System.Drawing.Color.OrangeRed;
            this.clearButton.BorderRadius = 14;
            this.clearButton.BorderSize = 2;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Enabled = false;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.clearButton.ForeColor = System.Drawing.SystemColors.Window;
            this.clearButton.Location = new System.Drawing.Point(22, 506);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(263, 40);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.TextColor = System.Drawing.SystemColors.Window;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // occurenceCheckBox
            // 
            this.occurenceCheckBox.AutoSize = true;
            this.occurenceCheckBox.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.occurenceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.occurenceCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.occurenceCheckBox.Location = new System.Drawing.Point(28, 317);
            this.occurenceCheckBox.MinimumSize = new System.Drawing.Size(0, 21);
            this.occurenceCheckBox.Name = "occurenceCheckBox";
            this.occurenceCheckBox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.occurenceCheckBox.Size = new System.Drawing.Size(171, 24);
            this.occurenceCheckBox.TabIndex = 16;
            this.occurenceCheckBox.Text = "Find All Occurence";
            this.occurenceCheckBox.UnCheckedColor = System.Drawing.Color.DodgerBlue;
            this.occurenceCheckBox.UseVisualStyleBackColor = true;
            this.occurenceCheckBox.CheckedChanged += new System.EventHandler(this.occurenceCheckBox_CheckedChanged);
            // 
            // radioButtonDFS
            // 
            this.radioButtonDFS.AutoSize = true;
            this.radioButtonDFS.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonDFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonDFS.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButtonDFS.Location = new System.Drawing.Point(27, 412);
            this.radioButtonDFS.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioButtonDFS.Name = "radioButtonDFS";
            this.radioButtonDFS.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButtonDFS.Size = new System.Drawing.Size(70, 24);
            this.radioButtonDFS.TabIndex = 16;
            this.radioButtonDFS.TabStop = true;
            this.radioButtonDFS.Text = "DFS";
            this.radioButtonDFS.UnCheckedColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonDFS.UseVisualStyleBackColor = true;
            // 
            // chooseFolderButton
            // 
            this.chooseFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.chooseFolderButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.chooseFolderButton.BorderColor = System.Drawing.Color.DodgerBlue;
            this.chooseFolderButton.BorderRadius = 10;
            this.chooseFolderButton.BorderSize = 2;
            this.chooseFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseFolderButton.FlatAppearance.BorderSize = 0;
            this.chooseFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chooseFolderButton.ForeColor = System.Drawing.Color.Cyan;
            this.chooseFolderButton.Location = new System.Drawing.Point(25, 174);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(110, 28);
            this.chooseFolderButton.TabIndex = 16;
            this.chooseFolderButton.Text = "Choose Folder";
            this.chooseFolderButton.TextColor = System.Drawing.Color.Cyan;
            this.chooseFolderButton.UseVisualStyleBackColor = false;
            this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
            // 
            // radioButtonBFS
            // 
            this.radioButtonBFS.AutoSize = true;
            this.radioButtonBFS.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonBFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonBFS.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButtonBFS.Location = new System.Drawing.Point(27, 384);
            this.radioButtonBFS.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioButtonBFS.Name = "radioButtonBFS";
            this.radioButtonBFS.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButtonBFS.Size = new System.Drawing.Size(69, 24);
            this.radioButtonBFS.TabIndex = 15;
            this.radioButtonBFS.TabStop = true;
            this.radioButtonBFS.Text = "BFS";
            this.radioButtonBFS.UnCheckedColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonBFS.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.BorderColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.BorderRadius = 14;
            this.searchButton.BorderSize = 2;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.searchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.searchButton.Location = new System.Drawing.Point(22, 453);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(263, 40);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.TextColor = System.Drawing.SystemColors.Window;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Authors
            // 
            this.Authors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Authors.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Authors.Location = new System.Drawing.Point(0, 554);
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(316, 142);
            this.Authors.TabIndex = 15;
            this.Authors.Text = "Developed By\r\n\r\n13520058 - Kristo Abdi Wiguna\r\n13520076 - Claudia\r\n13520080 - Jas" +
    "on Kanggara";
            this.Authors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.logoPanel.Controls.Add(this.GroupName);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(316, 85);
            this.logoPanel.TabIndex = 14;
            // 
            // GroupName
            // 
            this.GroupName.AutoSize = true;
            this.GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.GroupName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupName.Location = new System.Drawing.Point(17, 25);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(284, 31);
            this.GroupName.TabIndex = 14;
            this.GroupName.Text = "MencariNafasPertama\r\n";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.panelTitle.Controls.Add(this.Line);
            this.panelTitle.Controls.Add(this.Title);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(316, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(668, 85);
            this.panelTitle.TabIndex = 14;
            // 
            // Line
            // 
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Line.Location = new System.Drawing.Point(0, 83);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(668, 2);
            this.Line.TabIndex = 15;
            // 
            // resultPanel
            // 
            this.resultPanel.AutoScroll = true;
            this.resultPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.resultPanel.Controls.Add(this.timeSpent);
            this.resultPanel.Controls.Add(this.fileLocationLink);
            this.resultPanel.Controls.Add(this.fileLocationLabel);
            this.resultPanel.Controls.Add(this.resultLabel);
            this.resultPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resultPanel.Location = new System.Drawing.Point(316, 499);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(668, 197);
            this.resultPanel.TabIndex = 15;
            // 
            // timeSpent
            // 
            this.timeSpent.AutoSize = true;
            this.timeSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.timeSpent.ForeColor = System.Drawing.SystemColors.Window;
            this.timeSpent.Location = new System.Drawing.Point(430, 9);
            this.timeSpent.Name = "timeSpent";
            this.timeSpent.Size = new System.Drawing.Size(0, 24);
            this.timeSpent.TabIndex = 3;
            // 
            // fileLocationLink
            // 
            this.fileLocationLink.AutoSize = true;
            this.fileLocationLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fileLocationLink.ForeColor = System.Drawing.SystemColors.Window;
            this.fileLocationLink.LinkColor = System.Drawing.Color.Cyan;
            this.fileLocationLink.Location = new System.Drawing.Point(10, 63);
            this.fileLocationLink.Name = "fileLocationLink";
            this.fileLocationLink.Size = new System.Drawing.Size(0, 17);
            this.fileLocationLink.TabIndex = 2;
            this.fileLocationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fileLocationLink_LinkClicked);
            // 
            // fileLocationLabel
            // 
            this.fileLocationLabel.AutoSize = true;
            this.fileLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fileLocationLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.fileLocationLabel.Location = new System.Drawing.Point(10, 43);
            this.fileLocationLabel.Name = "fileLocationLabel";
            this.fileLocationLabel.Size = new System.Drawing.Size(0, 17);
            this.fileLocationLabel.TabIndex = 1;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.resultLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.resultLabel.Location = new System.Drawing.Point(9, 9);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(62, 24);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "Result";
            // 
            // graphPanel
            // 
            this.graphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphPanel.Location = new System.Drawing.Point(316, 85);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(668, 414);
            this.graphPanel.TabIndex = 16;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.InputPanel);
            this.Name = "mainWindow";
            this.Text = "Form1";
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label startingDirectoryLabel;
        private System.Windows.Forms.Label startingDirectory;
        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.TextBox inputFileTextField;
        private System.Windows.Forms.Label findingMethodLabel;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Label GroupName;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label Authors;
        private System.Windows.Forms.Label Line;
        private Custom_controls.CustomButton chooseFolderButton;
        private Custom_controls.CustomButton searchButton;
        private Custom_controls.CustomRadioButton radioButtonDFS;
        private Custom_controls.CustomRadioButton radioButtonBFS;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Label timeSpent;
        private System.Windows.Forms.LinkLabel fileLocationLink;
        private System.Windows.Forms.Label fileLocationLabel;
        private System.Windows.Forms.Label resultLabel;
        private Custom_controls.CustomCheckBox occurenceCheckBox;
        private System.Windows.Forms.Panel graphPanel;
        private Custom_controls.CustomButton clearButton;
    }
}

