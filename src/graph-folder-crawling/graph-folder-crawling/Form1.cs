using System;
using System.IO;
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
        private static float execTime;
        // Find all occurence check;
        private static bool findAllOccurence = false;
        // lokasi file setelah melakukan pencarian
        private static List<string> fileLocationResult = new List<string> { };

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
            // BFS and DFS method depends on choice
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (searchMethod == "bfs")
            {
                BFS(startDirectory, fileName);
            } else if (searchMethod == "dfs")
            {
                DFS(startDirectory, fileName);
            }
            watch.Stop();
            float elapsedMs = watch.ElapsedMilliseconds;
            execTime = elapsedMs / 1000;

            if (fileLocationResult.Count == 0)
            {
                MessageBox.Show("File not found");
            } else
            {
                // Menampilkan Graph
                if (searchMethod == "bfs")
                {
                    // Graph for BFS
                }
                else if (searchMethod == "dfs")
                {
                    // Graph for DFS
                }


                fileLocationLabel.Text = "Path File :";

                if (findAllOccurence)
                {
                    var stringBuilder = new StringBuilder();
                    var links = new List<LinkLabel.Link>();

                    foreach (var fileDir in fileLocationResult)
                    {
                        if (stringBuilder.Length > 0) stringBuilder.AppendLine();

                        links.Add(new LinkLabel.Link(stringBuilder.Length, fileDir.Length, fileDir));
                        stringBuilder.Append(fileDir);
                    }

                    fileLocationLink.Text = stringBuilder.ToString();
                    foreach (var link in links)
                    {
                        fileLocationLink.Links.Add(link);
                    }
                }
                else
                {
                    var stringBuilder = new StringBuilder();
                    var links = new List<LinkLabel.Link>();

                    var fileDir = fileLocationResult.First();

                    if (stringBuilder.Length > 0) stringBuilder.AppendLine();

                    links.Add(new LinkLabel.Link(stringBuilder.Length, fileDir.Length, fileDir));
                    stringBuilder.Append(fileDir);

                    fileLocationLink.Text = stringBuilder.ToString();
                    foreach (var link in links)
                    {
                        fileLocationLink.Links.Add(link);
                    }
                }

                // execTime disesuaikan dengan lama pencarian
                timeSpent.Text = "Time Spent: " + execTime + "s";

                clearButton.Enabled = true;
            }
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

            System.Diagnostics.Process.Start((string)e.Link.LinkData);
        }

        private static void DFS(string root, string target)
        {
            List<string> listFilesAndDirectory = new List<string> { };
            AddFiles(root, ref listFilesAndDirectory);
            if ((listFilesAndDirectory != null) && (listFilesAndDirectory.Count > 0)) // Check if list is not empty and not null
            {
                foreach (string filedir in listFilesAndDirectory)
                {
                    if (File.Exists(filedir))
                    {
                        // path is a file.
                        if (filedir.Contains(target))
                        {
                            // path is the target
                            fileLocationResult.Add(filedir);
                            // if find all occurence false
                            // break the loop
                            if (!findAllOccurence)
                            {
                                break;
                            }
                        }
                    }
                    else if (Directory.Exists(filedir))
                    {
                        // path is a directory => call recursive
                        DFS(filedir, target);
                    }
                }
            }
        }

        private static void BFS(string root, string target)
        {
            List<string> listFilesAndDirectory = new List<string> { };
            AddFiles(root, ref listFilesAndDirectory);
            if ((listFilesAndDirectory != null) && (listFilesAndDirectory.Count > 0)) // Check if list is not empty and not null
            {
                Queue<string> toVisitQueue = new Queue<string> { };

                foreach (string filedir in listFilesAndDirectory)
                {
                    Console.WriteLine(filedir);
                    if (Directory.Exists(filedir)) // if it is a folder, add to queue
                    {
                        toVisitQueue.Enqueue(filedir);
                    }
                    else if (File.Exists(filedir)) // if there is a file
                    {
                        if (filedir.Contains(target)) // check if it is the target file
                        {
                            fileLocationResult.Add(filedir);
                            // if find all occurence false
                            // break the loop
                            if (!findAllOccurence)
                            {
                                break;
                            }
                        }
                    }
                }

                // visit all vertex in queue
                while (toVisitQueue.Count > 0)
                {
                    string currentDirectory = toVisitQueue.Dequeue();

                    List<string> listChildFilesAndDirectory = new List<string> { };
                    AddFiles(currentDirectory, ref listChildFilesAndDirectory);
                    foreach (string child in listChildFilesAndDirectory)
                    {
                        if (Directory.Exists(child)) // if it is a folder, add to queue
                        {
                            toVisitQueue.Enqueue(child);
                        }
                        else if (File.Exists(child)) // if it is a file
                        {
                            if (child.Contains(target)) // check if it is the target file
                            {
                                fileLocationResult.Add(child);
                                // if find all occurence false
                                // break the loop
                                if (!findAllOccurence)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }

            }
        }

        private static void AddFiles(string root, ref List<string> listFilesAndDirectory)
        {
            // Return vertices consist of files and sub-directories from root
            try
            {
                List<string> folder = Directory.GetDirectories(root).ToList();
                string[] filesInFolder = Directory.GetFiles(root);
                foreach (var file in filesInFolder)
                {
                    folder.Add(file);
                }
                listFilesAndDirectory = folder;
            }
            catch (UnauthorizedAccessException ex)
            {
            }
        }

        private void occurenceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            findAllOccurence = !findAllOccurence;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fileLocationResult.Clear();
            fileLocationLink.Links.Clear();
            fileLocationLink.Text = "";
            fileLocationLabel.Text = "";
            timeSpent.Text = "";
            clearButton.Enabled = false;
        }
    }
}
