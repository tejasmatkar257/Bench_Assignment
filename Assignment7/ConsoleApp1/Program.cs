using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileIODemo;

namespace FileIO_Assignment
{
    class Stream
    {

        static void Main(string[] args)
        {
            try
            {
                string text = System.IO.File.ReadAllText(@"D:\MyDirectory\myfiles\MyFile.txt");
                System.Console.WriteLine("Contents of text file = {0} ", text);
                string[] lines = System.IO.File.ReadAllLines(@"D:\MyDirectory\myfiles\MyFile.txt");
                System.Console.WriteLine("Contents of text file2 = ");
                foreach (string line in lines)
                {
                    Console.WriteLine("\t " + line);
                }
                Console.WriteLine("press any key to exit.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            DirectoryFiles.Main(args);
            System.Console.ReadKey();

        }
    }
}