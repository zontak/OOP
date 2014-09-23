using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Battery b1 = new Battery("Li-Lon, 4100 mAH", 12);
            Laptop laptop = new Laptop("Lenovo", 12123, "faewfaew", "fawhts","12ad", "aegeh3","12aawe", "aefew", b1);
            Console.WriteLine(laptop.ToString());
        }
    }
}
