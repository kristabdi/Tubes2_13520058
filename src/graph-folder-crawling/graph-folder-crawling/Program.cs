using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph_folder_crawling
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new mainWindow());
            // Main
            string root = @"D:\";

            List<string> files = new List<string> {};
            string target = "Kelompok07SGDPolusiCahaya.txt";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            DFS(root, target);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
            //foreach (var array in files)
            //Console.WriteLine(string.Join(" ", array));
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
                            Console.WriteLine(filedir);
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
                    if (Directory.Exists(filedir))
                    {
                        toVisitQueue.Enqueue(filedir);
                    } else if (File.Exists(filedir))
                    {
                        if (filedir.Contains(target))
                        {
                            Console.WriteLine("Exists File at" + filedir);
                        }
                    }

                    Console.WriteLine("tes");
                }

                while (toVisitQueue.Count > 0)
                {
                    string currentDirectory = toVisitQueue.Dequeue();

                    List<string> listChildFilesAndDirectory = new List<string> { };
                    AddFiles(currentDirectory, ref listChildFilesAndDirectory);
                    foreach (string child in listChildFilesAndDirectory)
                    {
                        if (Directory.Exists(child)) {
                            toVisitQueue.Enqueue(child);
                            Console.WriteLine(child);
                            Console.WriteLine("tes2");
                        } else if (File.Exists(child))
                        {
                            if (child.Contains(target))
                            {
                                Console.WriteLine("Exists File2 at" + child);
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
    }
}
