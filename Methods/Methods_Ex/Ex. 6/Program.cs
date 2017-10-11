using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._6
{
    class Program
    {
        static void ReverseNum(decimal num)
        {
            int counter = 0;
            while (counter < num % 10)
            {
                counter++;
                num %= 10;
            }

        }
            
        static void Main(string[] args)
        {
            
        }
    }
}
