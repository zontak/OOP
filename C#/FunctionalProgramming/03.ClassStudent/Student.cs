using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.ClassStudent
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; private set; }
        public long GroupNumber { get; private set; }
        public Student(string firstName, string lastName, int age, string facultyNumber, string phone, string email,
            IList<int> marks, long groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public override string ToString()
        {
            StringBuilder student = new StringBuilder();
            student.AppendLine("First Name: " + this.FirstName);
            student.AppendLine("Last Name: " + this.LastName);
            student.AppendLine("Age: " + this.Age);
            student.AppendLine("Faculty number: " + this.FacultyNumber);
            student.AppendLine("Phone: " + this.Phone);
            student.AppendLine("Email: " + this.Email);
            student.Append("Marks: ");
            student.AppendLine(string.Join(",", this.Marks));
            student.AppendLine("Group number: " + this.GroupNumber); 
            return student.ToString();
        }

        public static string CountMarks(IList<Student> students, int mark, int countMarks)
        {
            StringBuilder str = new StringBuilder();
            foreach (var student in students)
            {
                List<int> listWithMarks = new List<int>();
                for (int i = 0; i < student.Marks.Count; i++)
                {
                    if (student.Marks[i] == mark)
                    {
                        listWithMarks.Add(6);
                    }
                }
                if (listWithMarks.Count != countMarks)
                {
                    Console.WriteLine(student.FirstName + " haven't required '" + countMarks + "' marks: " + mark );
                    continue;
                }
                else
                {
                    str.AppendLine(student.FirstName + " has reuqired marks: " + string.Join(",", student.Marks));
                }
            }
            return str.ToString();
        }
    }
}
