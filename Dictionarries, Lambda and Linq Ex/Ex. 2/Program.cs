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
            var events = new Dictionary<DateTime, string>();
            events[new DateTime(2017, 2, 18)] = "IDK";

            foreach (var sth in events)
            {
                Console.WriteLine($"{sth.Key:MM/dd/yyyy} -> {sth.Value}");

            }
        }
    }
}
