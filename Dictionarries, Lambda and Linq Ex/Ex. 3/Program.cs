using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<double, int>
            {
                {3.14, 7 },
                {8.33, 2 },
                {55.55, 3 },

            };

            var sorted = dict.OrderBy(x => x.Value).ThenBy(x => x.Key);
            Console.WriteLine(String.Join(", ", sorted
                .Select(x => " key: " + x.Key + 
                " and value: " + x.Value)));
        }
    }
}
