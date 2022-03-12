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
            this.startingDirectoryButton = new System.Windows.Forms.Button();
            this.startingDirectory = new System.Windows.Forms.Label();
            this.inputFileLabel = new System.Windows.Forms.Label();
            this.inputFileTextField = new System.Windows.Forms.TextBox();
            this.findingMethodLabel = new System.Windows.Forms.Label();
            this.radioButtonBFS = new System.Windows.Forms.RadioButton();
            this.radioButtonDFS = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.Line = new System.Windows.Forms.Label();
            this.InputPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(586, 85);
            this.Title.TabIndex = 0;
            this.Title.Text = "Folder Crawler";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.inputLabel.Location = new System.Drawing.Point(22, 107);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(82, 36);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Input";
            // 
            // startingDirectoryLabel
            // 
            this.startingDirectoryLabel.AutoSize = true;
            this.startingDirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startingDirectoryLabel.Location = new System.Drawing.Point(26, 151);
            this.startingDirectoryLabel.Name = "startingDirectoryLabel";
            this.startingDirectoryLabel.Size = new System.Drawing.Size(185, 20);
            this.startingDirectoryLabel.TabIndex = 3;
            this.startingDirectoryLabel.Text = "Choose starting directory";
            // 
            // startingDirectoryButton
            // 
            this.startingDirectoryButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.startingDirectoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startingDirectoryButton.FlatAppearance.BorderSize = 0;
            this.startingDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startingDirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.startingDirectoryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startingDirectoryButton.Location = new System.Drawing.Point(28, 176);
            this.startingDirectoryButton.Name = "startingDirectoryButton";
            this.startingDirectoryButton.Size = new System.Drawing.Size(110, 25);
            this.startingDirectoryButton.TabIndex = 4;
            this.startingDirectoryButton.Text = "Choose Folder";
            this.startingDirectoryButton.UseVisualStyleBackColor = false;
            this.startingDirectoryButton.Click += new System.EventHandler(this.startingDirectoryButton_Click);
            // 
            // startingDirectory
            // 
            this.startingDirectory.AutoSize = true;
            this.startingDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.startingDirectory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startingDirectory.Location = new System.Drawing.Point(27, 207);
            this.startingDirectory.Name = "startingDirectory";
            this.startingDirectory.Size = new System.Drawing.Size(91, 15);
            this.startingDirectory.TabIndex = 5;
            this.startingDirectory.Text = "No File Chosen";
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.AutoSize = true;
            this.inputFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputFileLabel.Location = new System.Drawing.Point(24, 235);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(121, 20);
            this.inputFileLabel.TabIndex = 6;
            this.inputFileLabel.Text = "Input File Name";
            // 
            // inputFileTextField
            // 
            this.inputFileTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputFileTextField.Location = new System.Drawing.Point(28, 259);
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
            this.findingMethodLabel.Location = new System.Drawing.Point(24, 308);
            this.findingMethodLabel.Name = "findingMethodLabel";
            this.findingMethodLabel.Size = new System.Drawing.Size(179, 20);
            this.findingMethodLabel.TabIndex = 8;
            this.findingMethodLabel.Text = "Input Metode Pencarian";
            // 
            // radioButtonBFS
            // 
            this.radioButtonBFS.AutoSize = true;
            this.radioButtonBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonBFS.Location = new System.Drawing.Point(28, 334);
            this.radioButtonBFS.Name = "radioButtonBFS";
            this.radioButtonBFS.Size = new System.Drawing.Size(59, 24);
            this.radioButtonBFS.TabIndex = 9;
            this.radioButtonBFS.TabStop = true;
            this.radioButtonBFS.Text = "BFS";
            this.radioButtonBFS.UseVisualStyleBackColor = true;
            // 
            // radioButtonDFS
            // 
            this.radioButtonDFS.AutoSize = true;
            this.radioButtonDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonDFS.Location = new System.Drawing.Point(28, 361);
            this.radioButtonDFS.Name = "radioButtonDFS";
            this.radioButtonDFS.Size = new System.Drawing.Size(60, 24);
            this.radioButtonDFS.TabIndex = 10;
            this.radioButtonDFS.TabStop = true;
            this.radioButtonDFS.Text = "DFS";
            this.radioButtonDFS.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.searchButton.Location = new System.Drawing.Point(41, 402);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(230, 45);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.InputPanel.Controls.Add(this.label2);
            this.InputPanel.Controls.Add(this.logoPanel);
            this.InputPanel.Controls.Add(this.inputLabel);
            this.InputPanel.Controls.Add(this.searchButton);
            this.InputPanel.Controls.Add(this.startingDirectoryLabel);
            this.InputPanel.Controls.Add(this.radioButtonDFS);
            this.InputPanel.Controls.Add(this.startingDirectoryButton);
            this.InputPanel.Controls.Add(this.radioButtonBFS);
            this.InputPanel.Controls.Add(this.startingDirectory);
            this.InputPanel.Controls.Add(this.findingMethodLabel);
            this.InputPanel.Controls.Add(this.inputFileLabel);
            this.InputPanel.Controls.Add(this.inputFileTextField);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputPanel.Location = new System.Drawing.Point(0, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(316, 609);
            this.InputPanel.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(0, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 142);
            this.label2.TabIndex = 15;
            this.label2.Text = "Developed By\r\n\r\n13520058 - Kristo Abdi Wiguna\r\n13520076 - Claudia\r\n13520080 - Jas" +
    "on Kanggara";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.logoPanel.Controls.Add(this.label1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(316, 85);
            this.logoPanel.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "MencariNafasPertama\r\n";
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.Line);
            this.panelTitle.Controls.Add(this.Title);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(316, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(586, 85);
            this.panelTitle.TabIndex = 14;
            // 
            // Line
            // 
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Line.Location = new System.Drawing.Point(0, 83);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(586, 2);
            this.Line.TabIndex = 15;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 609);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.InputPanel);
            this.Name = "mainWindow";
            this.Text = "Form1";
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label startingDirectoryLabel;
        private System.Windows.Forms.Button startingDirectoryButton;
        private System.Windows.Forms.Label startingDirectory;
        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.TextBox inputFileTextField;
        private System.Windows.Forms.Label findingMethodLabel;
        private System.Windows.Forms.RadioButton radioButtonBFS;
        private System.Windows.Forms.RadioButton radioButtonDFS;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Line;
    }
}

