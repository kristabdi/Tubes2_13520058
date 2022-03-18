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
        // hubungan folder dengan file
        private static List<List<string>> adjacencyList = new List<List<string>>();
        //create a viewer object 
        private static Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        //create a graph object 
        private static Microsoft.Msagl.Drawing.Graph graph;
        // check if file found for find all occurence false, then stop
        private static bool found = false;
        // location list
        private static List<List<string>> locationList = new List<List<string>>();
        // visited and unvisited
        private static List<string> visited = new List<string>();
        private static List<string> unvisited = new List<string>();


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
                BFS(startDirectory, fileName, findAllOccurence);
            } else if (searchMethod == "dfs")
            {
                DFS(startDirectory, fileName, findAllOccurence);
            }
            watch.Stop();
            float elapsedMs = watch.ElapsedMilliseconds;
            execTime = elapsedMs / 1000;

            getLocationList();

            if (fileLocationResult.Count == 0)
            {
                MessageBox.Show("File not found");
            } else
            {
                // Menampilkan Graph
                if (searchMethod == "bfs")
                {
                    // Graph for BFS
                    graph = new Microsoft.Msagl.Drawing.Graph("graph");
                    //create the graph content 
                    foreach (List<string> connection in adjacencyList)
                    {
                        graph.AddEdge(connection[0], connection[1]);

                    }
                    //bind the graph to the viewer 
                    viewer.Graph = graph;
                    //associate the viewer with the form 
                    viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                    graphPanel.Controls.Add(viewer);
                }
                else if (searchMethod == "dfs")
                {
                    // Graph for DFS
                    graph = new Microsoft.Msagl.Drawing.Graph("graph");
                    //create the graph content 
                    if (adjacencyList.Count > 0)
                    {
                        foreach (List<string> connection in adjacencyList)
                        {
                            graph.AddEdge(connection[0], connection[1]).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            graph.FindNode(connection[0]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                            graph.FindNode(connection[1]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                        }
                    }
                    
                    foreach (List<string> location in locationList)
                    {
                        graph.AddEdge(location[0], location[1]).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        graph.FindNode(location[0]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
                        graph.FindNode(location[1]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
                    }
                    //bind the graph to the viewer 
                    viewer.Graph = graph;
                    //associate the viewer with the form 
                    viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                    graphPanel.Controls.Add(viewer);
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

        private static void DFS(string root, string target, bool findAll)
        {
            List<string> listFilesAndDirectory = new List<string> { };
            AddFiles(root, ref listFilesAndDirectory);
            if ((listFilesAndDirectory != null) && (listFilesAndDirectory.Count > 0)) // Check if list is not empty and not null
            {
                foreach (string filedir in listFilesAndDirectory)
                {
                    adjacencyList.Add(new List<string> { root, filedir });
                    if (File.Exists(filedir))
                    {
                        // path is a file.
                        if (filedir.Contains(target))
                        {
                            // path is the target
                            fileLocationResult.Add(filedir);
                            found = true;
                        }
                    }
                    else if (Directory.Exists(filedir))
                    {
                        // path is a directory => call recursive
                        DFS(filedir, target, findAll);
                        if (!findAll && found) return;
                    }
                }
            }
        }

        private static void BFS(string root, string target, bool findAll)
        {
            List<string> listFilesAndDirectory = new List<string> { };
            AddFiles(root, ref listFilesAndDirectory);
            if ((listFilesAndDirectory != null) && (listFilesAndDirectory.Count > 0)) // Check if list is not empty and not null
            {
                Queue<string> toVisitQueue = new Queue<string> { };

                foreach (string filedir in listFilesAndDirectory)
                {
                    adjacencyList.Add(new List<string> { root, filedir });
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
                            if (!findAll) return;
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
                        adjacencyList.Add(new List<string> { currentDirectory, child });
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
                                if (!findAll) return;
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
            // belom bisa clear graph
            graphPanel.Controls.Clear();
            fileLocationLink.Text = "";
            fileLocationLabel.Text = "";
            timeSpent.Text = "";
            clearButton.Enabled = false;
        }

        private void getLocationList()
        {
            for (int i = adjacencyList.Count - 1; i >= 0; i--)
            {
                if (locationList.Count == 0)
                {
                    if (Path.GetFileName(adjacencyList[i][1]) == fileName)
                    {
                        locationList.Add(new List<string> { adjacencyList[i][0], adjacencyList[i][1] });
                        adjacencyList.RemoveAt(i);
                    }
                } else
                {
                    if (locationList.Last()[0] == adjacencyList[i][1])
                    {
                        locationList.Add(new List<string> { adjacencyList[i][0], adjacencyList[i][1] });
                        adjacencyList.RemoveAt(i);
                    }
                }
            }

            locationList.Reverse();
        }
        
        private static void removeResultVisited(List<string> pathOFTarget)
        {
            foreach (string filedir in pathOFTarget)
            {
                int index = visited.IndexOf(new DirectoryInfo(filedir).Name);
                visited.RemoveAt(index);
            }
        }

        private static void DFSNew(string root, string target, bool findAll)
        {
            List<string> listFilesAndDirectory = new List<string> { };
            AddFiles(root, ref listFilesAndDirectory);
            foreach (string filedir in listFilesAndDirectory)
            {
                unvisited.Add(new DirectoryInfo(filedir).Name);
            }
            if ((listFilesAndDirectory != null) && (listFilesAndDirectory.Count > 0)) // Check if list is not empty and not null
            {
                foreach (string filedir in listFilesAndDirectory)
                {
                    int index = unvisited.IndexOf(new DirectoryInfo(filedir).Name);
                    unvisited.RemoveAt(index);
                    visited.Add(new DirectoryInfo(filedir).Name);
                    adjacencyList.Add(new List<string> { new DirectoryInfo(root).Name, new DirectoryInfo(filedir).Name });
                    if (File.Exists(filedir))
                    {
                        // path is a file.
                        if (filedir.Contains(target))
                        {
                            // path is the target
                            //fileLocationResult.Add(filedir);
                            found = true;
                        }
                    }
                    else if (Directory.Exists(filedir))
                    {
                        // path is a directory => call recursive
                        DFS(filedir, target, findAll);
                        if (!findAll && found) return;
                    }
                }
            }
        }
        
    }
}
