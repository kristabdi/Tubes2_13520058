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
            this.Line = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Title.Location = new System.Drawing.Point(209, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(485, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "MencariNafasPertama - Folder Crawler";
            // 
            // Line
            // 
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Line.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Line.Location = new System.Drawing.Point(26, 50);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(850, 2);
            this.Line.TabIndex = 1;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.inputLabel.Location = new System.Drawing.Point(21, 61);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(65, 29);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Input";
            // 
            // startingDirectoryLabel
            // 
            this.startingDirectoryLabel.AutoSize = true;
            this.startingDirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startingDirectoryLabel.Location = new System.Drawing.Point(22, 99);
            this.startingDirectoryLabel.Name = "startingDirectoryLabel";
            this.startingDirectoryLabel.Size = new System.Drawing.Size(185, 20);
            this.startingDirectoryLabel.TabIndex = 3;
            this.startingDirectoryLabel.Text = "Choose starting directory";
            // 
            // startingDirectoryButton
            // 
            this.startingDirectoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startingDirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.startingDirectoryButton.Location = new System.Drawing.Point(26, 122);
            this.startingDirectoryButton.Name = "startingDirectoryButton";
            this.startingDirectoryButton.Size = new System.Drawing.Size(110, 25);
            this.startingDirectoryButton.TabIndex = 4;
            this.startingDirectoryButton.Text = "Choose Folder";
            this.startingDirectoryButton.UseVisualStyleBackColor = true;
            this.startingDirectoryButton.Click += new System.EventHandler(this.startingDirectoryButton_Click);
            // 
            // startingDirectory
            // 
            this.startingDirectory.AutoSize = true;
            this.startingDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.startingDirectory.Location = new System.Drawing.Point(142, 128);
            this.startingDirectory.Name = "startingDirectory";
            this.startingDirectory.Size = new System.Drawing.Size(91, 15);
            this.startingDirectory.TabIndex = 5;
            this.startingDirectory.Text = "No File Chosen";
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.AutoSize = true;
            this.inputFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputFileLabel.Location = new System.Drawing.Point(22, 159);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(121, 20);
            this.inputFileLabel.TabIndex = 6;
            this.inputFileLabel.Text = "Input File Name";
            // 
            // inputFileTextField
            // 
            this.inputFileTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputFileTextField.Location = new System.Drawing.Point(26, 182);
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
            this.findingMethodLabel.Location = new System.Drawing.Point(22, 219);
            this.findingMethodLabel.Name = "findingMethodLabel";
            this.findingMethodLabel.Size = new System.Drawing.Size(179, 20);
            this.findingMethodLabel.TabIndex = 8;
            this.findingMethodLabel.Text = "Input Metode Pencarian";
            // 
            // radioButtonBFS
            // 
            this.radioButtonBFS.AutoSize = true;
            this.radioButtonBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonBFS.Location = new System.Drawing.Point(26, 245);
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
            this.radioButtonDFS.Location = new System.Drawing.Point(26, 272);
            this.radioButtonDFS.Name = "radioButtonDFS";
            this.radioButtonDFS.Size = new System.Drawing.Size(60, 24);
            this.radioButtonDFS.TabIndex = 10;
            this.radioButtonDFS.TabStop = true;
            this.radioButtonDFS.Text = "DFS";
            this.radioButtonDFS.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.searchButton.Location = new System.Drawing.Point(26, 314);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 32);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 500);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.radioButtonDFS);
            this.Controls.Add(this.radioButtonBFS);
            this.Controls.Add(this.findingMethodLabel);
            this.Controls.Add(this.inputFileTextField);
            this.Controls.Add(this.inputFileLabel);
            this.Controls.Add(this.startingDirectory);
            this.Controls.Add(this.startingDirectoryButton);
            this.Controls.Add(this.startingDirectoryLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Title);
            this.Name = "mainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Line;
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
    }
}

