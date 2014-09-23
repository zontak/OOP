using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public class DropoutStudent : Student
    {
        private string droppedReason;

        public DropoutStudent(string firstName, string lastName, byte age, uint studentNumber, double averageGrade, string droppedReason) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DroppedReason = droppedReason;
        }

        public string DroppedReason
        {
            get
            {
                return this.droppedReason;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The reason cannot be empty");
                }

                this.droppedReason = value;
            }
        }

        public void Reapply()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("First Name: " + this.FirstName);
            sb.AppendLine("Last Name: " + this.LastName);
            sb.AppendLine("Age: " + this.Age);
            sb.AppendLine("Student Number: " + this.StudentNumber);
            sb.AppendLine("Average Grade: " + this.AverageGrade);
            sb.AppendLine("Dropout reason: " + this.droppedReason);

            Console.WriteLine(sb);
        }
    }
}
