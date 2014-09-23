using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{

    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(1, 2, 3);
            Point3D p2 = new Point3D(5, 6, 7);

            Console.WriteLine(Point3D.CalcDistances(p1, p2));
        }
    }
}
