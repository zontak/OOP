using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcats : Animal, ISound
    {
        public Tomcats(string name, int age) :
            base(name, "Male", age)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("I`m male cat and i say miauuu..");
        }
    }
}
