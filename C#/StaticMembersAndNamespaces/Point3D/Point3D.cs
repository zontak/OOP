using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Point3D
    {
        private double X { get; set; }
        private double Y { get; set; }
        private double Z { get; set; }

        private static readonly Point3D StartingPoing = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("X: " + this.X + ", Y: " + this.Y + ", Z: " + this.Z);
            return str.ToString();
        }

        public static double CalcDistances(Point3D p1, Point3D p2)
        {
            double part1 = p2.X - p1.X;
            double part2 = p2.Y - p1.Y;
            double part3 = p2.Z - p1.Z;
            double result = part1 * part1 + part2 * part2 + part3 * part3;
            result = Math.Sqrt(result);
            return result;
        }
    }
}
