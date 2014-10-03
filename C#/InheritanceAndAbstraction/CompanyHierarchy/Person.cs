using System;
using System.Text;

namespace CompanyHierarchy
{
    public abstract class Person : IPersonInterface
    {
        private string firstName;
        private string lastName;
        private int id;

        public Person(string firstName,string lastName,int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = id;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First Name cannot be null");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last Name cannot be null");
                }
                this.lastName = value;
            }
        }

        public int ID
        {
            get { return this.id; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("ID cannot be 0");
                }
                this.id = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("First name: " + this.FirstName);
            sb.AppendLine("Last name: " + this.LastName);
            sb.AppendLine("ID: " + this.ID);
            return sb.ToString();
        }
    }
}
