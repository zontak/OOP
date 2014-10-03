using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kittens : Animal, ISound
    {
        public Kittens(string name, int age) :
            base(name, "Female", age)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("I`m female cat and i say miauuu..");
        }
    }
}
