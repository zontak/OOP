using System;

namespace _01.Persons
{

    public class Person
    {
        private string name;
        private int age;
        private string email;
        private int countOfFucks;

        public Person(int age, string name, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.countOfFucks = 0;
        }
        public Person(int age, string name)
        {
            this.Name = name;
            this.Age = age;
            this.countOfFucks = 0;
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 100 || value < 1)
                {
                    throw new ArgumentOutOfRangeException("Rage of age is [1..100]");
                }

                this.age = value;

            }
        }

        public int CountOfFucks
        {
            get
            {
                return this.countOfFucks;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("You cannot set empty name");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value.IndexOf('@') == -1)
                {
                    throw new ArgumentException("That email must contain '@'");
                }
                else
                {
                    this.email = value;
                }
            }

        }
    }
}
