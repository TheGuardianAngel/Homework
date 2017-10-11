using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._4
{
    class Program
    {
        static int GetMax(int num1, int num2, int num3)
        {
            return Math.Max(Math.Max(num1, num2), num3);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
    }
}
