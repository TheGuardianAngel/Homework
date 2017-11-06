using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataServer = new Dictionary<string, SortedDictionary<string, int>>();
            var cache = new List<string>();
            var pattern = @"(\w +)\s->\s(\d +)\s\|\s(\w +)";
            
            while (true)
            {
                var input = Console.ReadLine().Split('{','}',' ','|').ToArray();
                var strInput = input.ToString();
                var match = Regex.Match(strInput, pattern);
                if (input[0] == "thetinggoesskrra")
                {
                    break;
                }
                else if (! dataServer.ContainsValue())
                {
                    
                }

            }
        }
    }
}
