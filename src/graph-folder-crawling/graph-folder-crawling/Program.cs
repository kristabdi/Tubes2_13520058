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
            string root = @"D:\ITB\IF";
            Console.WriteLine(root);
            //System.IO.DriveInfo di = new System.IO.DriveInfo(root);
            //System.IO.DirectoryInfo dirInfo = di.RootDirectory;
            //System.IO.DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*.*");

            // For getting file
            string target = "Tugas-Besar-2-IF2211-Strategi-Algoritma-2022.pdf";
            DFS(root, target);
        }
        private static void AddFiles(string root, List<string> listFilesAndDirectory)
        {
            try
            {
                List<string> folder = Directory.GetDirectories(root).ToList();
                string[] filesInFolder = Directory.GetFiles(root);
                foreach (var file in filesInFolder)
                {
                    folder.Add(file);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                   Console.Error.WriteLine(ex.Message);
            }
        }

        private static void DFS(string root, string target)
        {
            List<string> listFilesAndDirectory = new List<string> { };
            AddFiles(root, listFilesAndDirectory);
            if ((listFilesAndDirectory != null) && (!listFilesAndDirectory.Any())) // Check if list is not empty and not null
            {
                Console.WriteLine("Masuk 1");
                foreach (string filedir in listFilesAndDirectory)
                {
                    Console.WriteLine("Masuk 2");
                    if (File.Exists(filedir))
                    {
                        Console.WriteLine("Masuk 3");
                        // path is a file.
                        if (filedir.Contains(target))
                        {
                            Console.WriteLine(filedir);
                        }
                    }
                    else if (Directory.Exists(filedir))
                    {
                        Console.WriteLine("Masuk 4");
                        // path is a directory
                        DFS(filedir, target);
                    }
                }
            }
        }
    }
}
