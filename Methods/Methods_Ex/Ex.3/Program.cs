using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
    class Program
    {
        static void PrintName(string name)
        {

            Console.WriteLine($"Hello, {name}!");
        }

        static void Main(string[] args)
        {
            PrintName(Console.ReadLine());
        }
    }
}
