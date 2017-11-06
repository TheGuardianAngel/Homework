using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var encodedTxt = Console.ReadLine();
            var placeholder = Console.ReadLine().Split('{', '}', ' ').ToArray();
            var pattern = @"(.*)([A-Za-z]+)(\w+)(\1)(\2)";
            Regex reg = new Regex(pattern);
            var messege = Regex.Match(encodedTxt, pattern);
            Console.WriteLine(String.Concat(messege.Groups[1], messege.Groups[2],placeholder[1], messege.Groups[5]));

        }
    }
}
