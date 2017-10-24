using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allWords = File.ReadAllText("text.txt")
                .ToLower()
                .Split(new char[] {' ', '.', '!', '?', '\r', '\n', ',', '-'},
                    StringSplitOptions.RemoveEmptyEntries);
            var words = File.ReadAllText("words.txt").Split(' ');
            Dictionary<String, int> dict = new Dictionary<string, int>();

            foreach (var w in allWords)
            {
                 if (dict.ContainsKey(w))
                 {
                     dict[w]++;
                 }
                 else
                 {
                     dict[w] = 1;
                 }
            }

            File.WriteAllText("result.txt", "");
            foreach (var wordAndCount in dict.OrderByDescending(w => w.Value))
            {
                if (words.Contains(wordAndCount.Key))
                {
                    File.AppendAllText("result.txt",wordAndCount.Key + " -> " + wordAndCount.Value + Environment.NewLine);
                    
                }
            }
        }
    }
}
