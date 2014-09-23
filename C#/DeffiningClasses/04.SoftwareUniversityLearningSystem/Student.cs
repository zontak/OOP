using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public abstract class Student : Person
    {
        private uint studentNumber;
        private double averageGrade;
        public Student(string firstName, string lastName, byte age, uint studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public uint StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                if (value.ToString().Length != 10)
                {
                    throw new ArgumentNullException("Student number cannot be less than 0");
                }
                this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
            }
            set
            {
                if (value < 2.00 || value > 6.00)
                {
                    throw new ArgumentOutOfRangeException("average grade out of range [2..6]");
                }
                this.averageGrade = value;
            }
        }
    }
}
