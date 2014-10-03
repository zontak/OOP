using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> mmm = new List<Animal>()
            {
                new Cat("Beti","Female",5),
                new Dog("Sharo","Male",9),
                new Frog("Geri", "Female",2),
                new Kittens("Viki",6),
                new Tomcats("Muki", 3)
            };

            var age = 0;
            foreach (var anml in mmm)
            {
                age += ((Animal) anml).Age;
            }
        }
    }
}
