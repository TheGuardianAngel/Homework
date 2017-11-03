using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = new StringBuilder();
            for (int i = 0; i < 1000000; i++)
            {
                str.Append("PESHO");
            }
            Console.WriteLine(str.ToString());
        }
    }
}
