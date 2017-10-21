using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Dictionarries__Lambda_and_Linq_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            phonebook.Add("Sofia", String.Empty);
            phonebook["Nakov"] = "0889227840";
            phonebook["Pesho"] = "0763 / 76423";
            phonebook["Nakov"] = "new phone -> 0987654321";
            //phonebook.Remove("Nakov");
            phonebook["Ani"] = "1234567890";

            if (phonebook.ContainsKey("Sofia"))
            {
                phonebook.Remove("Sofia");
            }

            foreach (var item in phonebook)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
