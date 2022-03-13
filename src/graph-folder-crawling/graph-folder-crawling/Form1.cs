using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph_folder_crawling
{
    public partial class mainWindow : Form
    {
        // opsi metode pencarian BFS atau DFS
        private static string searchMethod;
        // starting directory
        private static string startDirectory;
        // file name tujuan
        private static string fileName;
        // Execution time
        private static double execTime = 30.05;
        // lokasi file setelah melakukan pencarian
        private static string fileLocationResult;

        public mainWindow()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (radioButtonBFS.Checked)
            {
                searchMethod = "bfs";
            } else if (radioButtonDFS.Checked)
            {
                searchMethod = "dfs";
            }

            if (inputFileTextField.Text != "e.g. \"word.pdf\"" || inputFileTextField.Text != "")
            {
                fileName = inputFileTextField.Text;
            } else
            {
                fileName = "Error: No file input";
            }
            // BFS dan DFS method
            /*
            if (searchMethod == "bfs")
            {
                fileLocationResult = bfs(startDirectory, fileName);
            } else if (searchMethod == "dfs")
            {
                fileLocationResult = dfs(startDirectory, fileName);
            }
            */

            fileLocationLabel.Text = "Path File :";

            // fileLocationResult nemu, startDirectory tinggal diganti sama fileLocationResult
            fileLocationLink.Text = startDirectory;
            // execTime disesuaikan dengan lama pencarian
            timeSpent.Text = "Time Spent: " + execTime + "s";

        }

        private void inputFileTextField_Enter(object sender, EventArgs e)
        {
            if (inputFileTextField.Text != "")
            {
                inputFileTextField.Text = "";
            }
        }

        private void inputFileTextField_Leave(object sender, EventArgs e)
        {
            if (inputFileTextField.Text == "")
            {
                inputFileTextField.Text = "e.g. \"word.pdf\"";
            }
        }

        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                startDirectory = fbd.SelectedPath;
                startingDirectory.Text = startDirectory;
            }
        }

        private void fileLocationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // fileLocationResult nemu, startDirectory tinggal diganti sama fileLocationResult
            System.Diagnostics.Process.Start(startDirectory);
        }

        // BFS Function
        /*
        private void bfs(string startDirectory, string fileName)
        {

        }
        */

        // DFS Function
        /*
        private void dfs(string startDirectory, string fileName)
        {

        }
        */
    }
}
