using System;

namespace Student
{
    class Student
    {
        private string name;
        private int age;
        public PropertyChangedEventHandler PropertyChanged;
        public Student(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (PropertyChanged != null)
                {
                    PropertyChangedEventArgs eventArgs = new PropertyChangedEventArgs("Name", this.name, value);
                    PropertyChanged(this, eventArgs);
                }

                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (PropertyChanged != null)
                {
                    PropertyChangedEventArgs eventArgs = new PropertyChangedEventArgs("Age", this.age, value);
                    PropertyChanged(this, eventArgs);
                }

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less than 0");
                }
                this.age = value;

            }
        }
    }
}
