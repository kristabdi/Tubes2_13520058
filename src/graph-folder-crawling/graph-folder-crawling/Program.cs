﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph_folder_crawling
{
    internal static class Program
    {
        private static List<List<string>> adjacencyList = new List<List<string>>();
        private static List<List<string>> locationList = new List<List<string>>();
        private static List<string> fileLocation = new List<string>();
        private static List<List<string>> unvisited = new List<List<string>>();
        private static bool found = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainWindow());
            

            // Main
            
            /*
            string root = @"D:\testcase\test";

            List<string> files = new List<string> {};
            string target = "file2.txt";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            bool findAll = false; // being input
            DFS(root, target, findAll);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
            
            foreach (List<string> connection in adjacencyList)
            {
                Console.WriteLine(connection[0] + " " + connection[1]);
            }

            Console.WriteLine();

            if (findAll)
            {
                for (int i = 0; i < fileLocation.Count; i++)
                {
                    getLocationList(target);

                }
            } else
            {
                getLocationList(target);
            }

            foreach(List<string> location in locationList)
            {
                Console.WriteLine(location[0] + " " + location[1]);
            }

            Console.WriteLine();  

            foreach (List<string> connection in unvisited)
            {
                Console.WriteLine(connection[0] + " " + connection[1]);
            }
            */
            // Console.WriteLine(adjacencyList.Count);

            //foreach (var array in files)
            //Console.WriteLine(string.Join(" ", array));
        }

        private static void DFS(string root, string target, bool findAll)
        {
            List<string> listFilesAndDirectory = new List<string> { };
            AddFiles(root, ref listFilesAndDirectory);
            foreach (string filedir in listFilesAndDirectory)
            {
                unvisited.Add(new List<string> { new DirectoryInfo(root).Name , new DirectoryInfo(filedir).Name });
            }
            if ((listFilesAndDirectory != null) && (listFilesAndDirectory.Count > 0)) // Check if list is not empty and not null
            {
                foreach (string filedir in listFilesAndDirectory)
                {
                    adjacencyList.Add(new List<string> { new DirectoryInfo(root).Name, new DirectoryInfo(filedir).Name });
                    if (File.Exists(filedir))
                    {
                        // path is a file.
                        if (filedir.Contains(target))
                        {
                            // path is the target
                            Console.WriteLine("Exists File at " + filedir);
                            fileLocation.Add(filedir);

                            found = true;
                        }
                    }
                    else if (Directory.Exists(filedir))
                    {
                        // path is a directory => call recursive
                        DFS(filedir, target, findAll);
                        if (!findAll && found)
                        {
                            return;
                        }
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
                    adjacencyList.Add(new List<string> { new DirectoryInfo(root).Name, new DirectoryInfo(filedir).Name });
                    if (Directory.Exists(filedir)) // if it is a folder, add to queue
                    {
                        toVisitQueue.Enqueue(filedir);
                    } 
                    else if (File.Exists(filedir)) // if there is a file
                    {
                        if (filedir.Contains(target)) // check if it is the target file
                        {
                            Console.WriteLine("Exists File at " + filedir);
                            fileLocation.Add(filedir);
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
                        adjacencyList.Add(new List<string> { new DirectoryInfo(currentDirectory).Name, new DirectoryInfo(child).Name });
                        if (Directory.Exists(child)) // if it is a folder, add to queue
                        {
                            toVisitQueue.Enqueue(child);
                        } 
                        else if (File.Exists(child)) // if it is a file
                        {
                            if (child.Contains(target)) // check if it is the target file
                            {
                                Console.WriteLine("Exists File at " + child);
                                fileLocation.Add(child);

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

        private static void getLocationList(string target)
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
                if (adjacencyList[i][1] == target && !found)
                {
                    locationList.Add(new List<string> { adjacencyList[i][0], adjacencyList[i][1] });
                    // adjacencyList.RemoveAt(i);
                    break;
                }
            }
            for (int i = adjacencyList.Count - 1; i >= 0; i--)
            {
                if (locationList.Last()[0] == adjacencyList[i][1])
                {
                    locationList.Add(new List<string> { adjacencyList[i][0], adjacencyList[i][1] });
                    // adjacencyList.RemoveAt(i);
                }
            }

            // locationList.Reverse();

        }
    }
}
