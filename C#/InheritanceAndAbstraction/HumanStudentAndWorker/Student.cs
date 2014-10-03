using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length > 10 || value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Faculty number has 5-10 Digits or Letters");
                }
                this.facultyNumber = value;
            }
        }

        public Student(string facultyNumber, string firstName,string lastName) :
            base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
    }
}
