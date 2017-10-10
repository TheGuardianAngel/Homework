using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Ex
{
    class Program
    {

        static void ReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 30));
        }
        static void ReceiptBody(string charged, string recieved)
        {
            Console.WriteLine("Charged to " + charged);
            Console.WriteLine("Recieved by " + recieved);
        }
        static void ReceiptFooter()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("\u00A9 SoftUni");
        }
      

        static void Main(string[] args)
        {
            ReceiptHeader();
            ReceiptBody("Angel", "IDK" );
            ReceiptFooter();
        }

       
    }
}
