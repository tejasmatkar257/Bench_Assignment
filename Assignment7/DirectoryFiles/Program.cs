using System;
using System.IO;
namespace FileIODemo
{
    class DirectoryFiles
    {
        public static void Main(string[] args)
        {
            string path = (@"D:\MyDirectory");
            string[] files = Directory.GetFiles(path);
            string[] directories =
            Directory.GetDirectories(path);


            Console.WriteLine("Displaying names of " +
              "files inside {0}\n", path);
            foreach (string file in files)
            {
                string fileNameWithoutExtension =
                  Path.GetFileNameWithoutExtension(file);
                Console.WriteLine(fileNameWithoutExtension);
            }

            Console.WriteLine("\n\nDisplaying names of " +
              "directories inside {0}\n", path);
            foreach (string directory in directories)
            {
                string directoryName = new DirectoryInfo(
                  Path.GetDirectoryName(directory)).Name;
                Console.WriteLine(directoryName);
            }


            Console.Read();
        }
    }

}