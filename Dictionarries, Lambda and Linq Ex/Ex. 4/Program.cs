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
             List < int > numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
