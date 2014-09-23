using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "pesho";

            Person pich = new Person(12, name, "fawfwae@");
            Console.WriteLine(pich.ToString());
        }
    }
}
