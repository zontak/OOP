using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private byte age;

        public Person(string firstName, string lastName, byte age)
        {
            this.Age = age;
            this.LastName = lastName;
            this.FirstName = firstName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The last name cannot be empty");
                }
                this.lastName = value;
            }
        }

        public byte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Ages cannot be less then 0");
                }
                this.age = value;
            }
        }

    }
}
