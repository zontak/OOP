using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public abstract class Trainer : Person
    {
        public Trainer(string firstName, string lastName, byte age)
            : base(firstName, lastName, age)
        {

        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("Course {0} has been created", courseName);
        }
    }
}
