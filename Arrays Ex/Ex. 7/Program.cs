﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] items = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();


            foreach (var x in items)
            {
                double rounded = Math.Round(x, 0, MidpointRounding.AwayFromZero);
                Console.WriteLine(rounded);
            }
        }
    }
}
