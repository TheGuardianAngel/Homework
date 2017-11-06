using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
            var patternMerge = @"\bmerge\b";
            var patternDivide = @"\bdivide\b";

            Regex regexMerge = new Regex(patternMerge);
            Regex regexDivide = new Regex(patternDivide);
            

            while (true)
            {

                var commands = Console.ReadLine().Split(' ').ToString();
                var arrCommands = commands.ToArray();

                var divided = String.Empty;
                var merged = String.Empty;

                bool isMerge = regexMerge.IsMatch(commands);
                bool isDivide = regexDivide.IsMatch(commands);

                if (isMerge)
                {
                    var counter = String.Concat(merged, String.Concat(data[arrCommands[1]], data[arrCommands[2]]));
                    if ()
                    {
                        Console.WriteLine(counter);
                        break;
                    }
                }
                else if (isDivide)
                {
                    
                }
                


            }
        }
    }
}
