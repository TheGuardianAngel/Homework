using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(items.Sum());

        }
    }
}
