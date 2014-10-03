using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ClassStudent
{
    class Program
    {
        static void Main()
        {
            // 03.
            List<Student> Students = new List<Student>();

            Students.Add(new Student("Petar", "Petrov", 21, "0220141231231", "021212131", "petar@abv.bg",
                new List<int>() {2, 3, 4, 5}, 1));
            Students.Add(new Student("Stoqn", "Stoilov", 53, "13201442454", "5736345", "stoqn@mail.bg",
                new List<int>() {2, 3, 6, 6}, 2));
            Students.Add(new Student("Georgi", "Georgiev", 37, "123124", "435464", "georgi@gmail.com",
                new List<int>() {2, 3, 6, 6}, 2));
            Students.Add(new Student("Ivan", "Stoimenov", 19, "435312", "2131241", "ivan@yahoo.com",
                new List<int>() {2, 3, 2, 5}, 1));

            // 04.
            var sortByGroup =
                from student in Students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            //foreach (var sort in sortByGroup)
            //{
            //    Console.WriteLine(sort);
            //}

            // 05.
            var sortByFirstName =
                from student in Students
                where student.FirstName.CompareTo(student.LastName) < 0
                orderby student.FirstName
                select student;

            //foreach (var sort in sortByFirstName)
            //{
            //    Console.WriteLine(sort);
            //}

            // 06.
            var sortByAge =
                from student in Students
                where student.Age < 24 && student.Age > 18
                orderby student.FirstName
                select "First Name: " + student.FirstName + "\nLast Name: "  + student.LastName + "\nAge: " + student.Age + "\n";

            //foreach (var sort in sortByAge)
            //{
            //    Console.WriteLine(sort);
            //}

            // 07.
            var sortStudents = Students.OrderByDescending(a => a.FirstName).ThenByDescending(b => b.LastName);

            //foreach (var sort in sortStudents)
            //{
            //    Console.WriteLine(sort);
            //}

            // 08.
            var sortByDomain =
                from student in Students
                where student.Email.Contains("@abv.bg")
                orderby student.FirstName
                select student;

            //foreach (var sort in sortByDomain)
            //{
            //    Console.WriteLine(sort);
            //}

            // 09.
            var sortByPhone =
                from student in Students
                where student.Phone.Contains("02") || student.Phone.Contains("+3592") || student.Phone.Contains("+359 2")
                orderby student.FirstName
                select student;

            //foreach (var sort in sortByPhone)
            //{
            //    Console.WriteLine(sort);
            //}

            // 10.
            var sortByExcelentStudent =
                from student in Students
                where student.Marks.Contains(6)
                orderby student.FirstName
                select student;

            //foreach (var sort in sortByExcelentStudent)
            //{
            //    Console.WriteLine(sort);
            //}

            // 11 question.. My function accept 3 parameters: 1.List with students 2.Mark 3.Count of marks
            //Console.WriteLine(Student.CountMarks(Students,2,2));

            // 12.
            var studentEnrolled =
                from student in Students
                where student.FacultyNumber[4] == '1' && student.FacultyNumber[5] == '4'
                orderby student.FirstName
                select student.FirstName + " have " + string.Join(",",student.Marks);

            //foreach (var sort in studentEnrolled)
            //{
            //    Console.WriteLine(sort);
            //}
        }
    }
}
