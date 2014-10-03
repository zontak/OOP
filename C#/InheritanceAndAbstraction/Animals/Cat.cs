using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, string gender, int age) :
            base(name, gender, age)
        {
        }


        public void ProduceSound()
        {
            Console.WriteLine("I say miauuuu...");
        }
    }
}
