using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private string gender;
        private int age;

        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Animal(string name,string gender,int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
    }
}
