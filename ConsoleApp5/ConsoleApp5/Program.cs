using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GetFiles("D:\\FallGuys");

        }

        private static void GetFiles(string Path)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(Path);
                FileInfo[] files = directory.GetFiles("*.*", SearchOption.AllDirectories);

                var query = from file in files
                            select $"File Name: {file.Name}  \nFile Size:   {(double)file.Length / 1024 / 1024} mb";
                foreach (string str in query)
                {
                    Console.WriteLine(str);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
