using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                ReadNumber(start, end);
            }

        }

        static void ReadNumber(int start, int end)
        {
            try
            {
                while(true)
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number >= start && number <= end)
                    {
                        break;
                    } 
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Try Again [{0}...{1}]", start, end);
            }
        }
    }
}
