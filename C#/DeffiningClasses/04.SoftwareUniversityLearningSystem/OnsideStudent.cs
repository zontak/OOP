using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public class OnsideStudent : CurrentStudent
    {
        private int numberOfVisits = 0;

        public OnsideStudent(string firstName, string lastName, byte age, uint studentNumber, double averageGrade, string currentCourse
            ,int numberOfVisits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get
            {
                return this.numberOfVisits;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number cannot be negative");
                }

                this.numberOfVisits = value;
            }
        }
    }
}
