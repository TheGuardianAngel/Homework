using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var securityKey = int.Parse(Console.ReadLine());
            decimal sum = 0M;
            var securityToken = Math.Pow(securityKey, n);
            for (int i = 0; i < n; i++)
            {
                var website = Console.ReadLine().Split(' ').ToArray();
                sum += decimal.Parse(website[1]) * decimal.Parse(website[2]);
                Console.WriteLine(website[0]);
            }

            
            Console.WriteLine($"Total Loss: {sum:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
