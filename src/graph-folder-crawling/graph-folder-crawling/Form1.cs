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
        private static string searchMethod = "";
        // starting directory
        private static string startDirectory = "";
        // file name tujuan
        private static string fileName = "";
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
        // list of unvisited directory or file in queue
        private static List<List<string>> unvisitedList = new List<List<string>>();


        public mainWindow()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (radioButtonBFS.Checked)
            {
                searchMethod = "bfs";
            }
            else if (radioButtonDFS.Checked)
            {
                searchMethod = "dfs";
            }

            if (inputFileTextField.Text != "e.g. \"word.pdf\"" && inputFileTextField.Text != "")
            {
                fileName = inputFileTextField.Text;
            }
            else
            {
                fileName = "";
            }

            if (fileName == "" && searchMethod == "" && startDirectory == "")
            {
                MessageBox.Show("Warning: Input not Complete!");
            }
            else
            {
                // BFS and DFS method depends on choice
                var watch = System.Diagnostics.Stopwatch.StartNew();
                if (searchMethod == "bfs")
                {
                    BFS(startDirectory, fileName, findAllOccurence);
                }
                else if (searchMethod == "dfs")
                {
                    DFS(startDirectory, fileName, findAllOccurence);
                }
                watch.Stop();
                float elapsedMs = watch.ElapsedMilliseconds;
                execTime = elapsedMs / 1000;

                if (fileLocationResult.Count > 0)
                {
                    for (int i = 0; i < fileLocationResult.Count; i++)
                    {
                        getLocationList();
                    }
                }
                else
                {
                    getLocationList();
                }

                // Graph for DFS and BFS
                graph = new Microsoft.Msagl.Drawing.Graph("graph");
                //create the graph content 
                foreach (List<string> connection in adjacencyList)
                {
                    bool found = false;
                    bool colored = false;
                    bool rootColored = false;
                    foreach (List<string> location in locationList)
                    {
                        if (Enumerable.SequenceEqual(connection, location))
                        {
                            found = true;
                        }
                    }
                    if (found)
                    {
                        graph.AddEdge(connection[0], connection[1]).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        graph.FindNode(connection[0]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
                        graph.FindNode(connection[1]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
                    }
                    else
                    {
                        foreach (List<string> location in locationList)
                        {
                            if (Enumerable.SequenceEqual(connection, location))
                            {
                                colored = true;
                            }
                            if (connection[0] == location[0])
                            {
                                rootColored = true;
                            }
                        }
                        graph.AddEdge(connection[0], connection[1]).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        if (!colored)
                        {
                            if (!rootColored)
                            {
                                graph.FindNode(connection[0]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                            }
                            graph.FindNode(connection[1]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                        }
                    }
                }
                if (!findAllOccurence)
                {
                    foreach (List<string> unvisitedElem in unvisitedList)
                    {
                        bool unvisited = true;
                        foreach (List<string> connection in adjacencyList)
                        {
                            if (Enumerable.SequenceEqual(unvisitedElem, connection))
                            {
                                unvisited = false;
                            }
                        }
                        if (unvisited)
                        {
                            graph.AddEdge(unvisitedElem[0], unvisitedElem[1]);
                        }
                    }
                }
                //bind the graph to the viewer 
                viewer.Graph = graph;
                //associate the viewer with the form 
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                graphPanel.Controls.Add(viewer);

                fileLocationLabel.Text = "Path File :";

                if (fileLocationResult.Count == 0)
                {
                    fileLocationLink.Text = "No File Found!";
                }
                else
                {
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
            foreach (string filedir in listFilesAndDirectory)
            {
                unvisitedList.Add(new List<string> { root, filedir });
            }
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
            foreach (string filedir in listFilesAndDirectory)
            {
                unvisitedList.Add(new List<string> { root, filedir });
            }
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
                        unvisitedList.Add(new List<string> { currentDirectory, child });
                    }
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
            adjacencyList.Clear();
            locationList.Clear();
            unvisitedList.Clear();
            found = false;
            fileLocationResult.Clear();
            fileLocationLink.Links.Clear();
            graphPanel.Controls.Clear();
            fileLocationLink.Text = "";
            fileLocationLabel.Text = "";
            timeSpent.Text = "";
            clearButton.Enabled = false;
        }

        private static void getLocationList()
        {

            for (int i = adjacencyList.Count - 1; i >= 0; i--)
            {
                bool found = false;
                foreach (List<string> location in locationList)
                {
                    if (Enumerable.SequenceEqual(adjacencyList[i], location))
                    {
                        found = true;
                        break;
                    }
                }
                if (Path.GetFileName(adjacencyList[i][1]) == fileName && !found)
                {
                    locationList.Add(new List<string> { adjacencyList[i][0], adjacencyList[i][1] });
                    break;
                }
            }
            for (int i = adjacencyList.Count - 1; i >= 0; i--)
            {
                if (locationList.Last()[0] == adjacencyList[i][1])
                {
                    locationList.Add(new List<string> { adjacencyList[i][0], adjacencyList[i][1] });
                }
            }
        }

    }
}