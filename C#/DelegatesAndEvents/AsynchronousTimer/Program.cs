using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncTimer timerOne = new AsyncTimer(firstFunc, 10, 5);
        }

        public static void firstFunc()
        {
            Console.WriteLine("This is first function");
        }

        public static void secondFunc()
        {
            Console.WriteLine("This is second function");
        }
    }
}
