using System;
using System.IO;

namespace _14_1_CheckIFDirectoryExists
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter a directory or type end to quit >> ");
                string input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    flag = false;
                    continue;

                }

                string directoryName;
                string[] listOfFiles;

                if (Directory.Exists(input))
                {
                   
                    
                    Console.WriteLine("The directory exists and it containes the following files:");
                    listOfFiles = Directory.GetFiles(input);
                    foreach (string file in listOfFiles)
                    {
                        Console.WriteLine(file);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Directory {0} does not exist", input);
                }
            }
        }
    }
}
