using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public class GraduateStudent : Student
    {
        public GraduateStudent(string firstName, string lastName, byte age, uint studentNumber, double averageGrade)
            : base(firstName, lastName, age ,studentNumber, averageGrade)
        {

        }
    }
}
