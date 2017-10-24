using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files__Directories_and_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] lines = File.ReadAllLines("new.txt");
            File.AppendAllText("new.txt", "\r\nniki");

            var  fileinfo = new FileInfo("new.txt");
            Console.WriteLine(fileinfo.Length);
            Console.WriteLine(fileinfo.CreationTime);
            Console.WriteLine(fileinfo.FullName);
            Console.WriteLine(fileinfo.Extension);
        }
    }
}
