﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var hexadecimal = Console.ReadLine();
            int num = Convert.ToInt32(hexadecimal, 16);
            Console.WriteLine(num);
        }
    }
}
