using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._7
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;
            // In N steps compute Fibonacci sequence iteractively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            Console.WriteLine(Fibonacci(int.Parse(Console.ReadLine())));
        }
    }

}

