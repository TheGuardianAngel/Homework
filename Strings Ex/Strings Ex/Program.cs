using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var forbiddenWords = Console.ReadLine().Split(',', ' ').Where(w => w.Length > 0).ToArray();
            var words = Console.ReadLine();

            foreach (var banned in forbiddenWords)
            {
                if (words.Contains(banned))
                {
                    words = words.Replace(banned, new string('*', banned.Length));
                }
            }
            Console.WriteLine(words);

            
        }
    }
}
