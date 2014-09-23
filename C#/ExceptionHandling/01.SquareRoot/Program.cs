using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter number!!! baby ;)");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter number {0} {1}", int.MinValue, int.MaxValue);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Enter number {0} {1}", int.MinValue, int.MaxValue);
            }
            finally
            {
                Console.WriteLine("sayni chaY");
            }
        }
    }
}
