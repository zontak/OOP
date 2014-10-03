using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CostumLINQExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int>() { 1, 5, 2, 4, 7, 9 };
            Console.WriteLine(string.Join(", ", numbers.WhereNot<int>(a => a == 4)));
            Console.WriteLine(string.Join(", ", numbers.Repeat<int>(4)));
            IEnumerable<string> stringItems = new List<string>() { "mql", "mrazz", "fas", "perde", "pfffffff" };
            IEnumerable<string> suffixes = new List<string>() { "ala", "ka" };
            Console.WriteLine(string.Join(", ", stringItems.WhereEndsWith(suffixes)));
        }
    }
}
