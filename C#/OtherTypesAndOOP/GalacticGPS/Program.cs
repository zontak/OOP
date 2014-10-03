using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    public enum Planet
    {
        Mercury, 
        Venus, 
        Earth, 
        Mars, 
        Jupiter,
        Saturn,
        Uranus,
        Neptune
    }


    public struct Location
    {
        private double Latitude { get; set; }
        private double Longitude { get; set; }
        private Planet Planet { get; set; }

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.Latitude + ", " + this.Longitude + " - " + this.Planet);
            return str.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
        }
    }
}
