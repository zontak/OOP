using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudentsOne = new List<Student>()
            {
                new Student("Petyr",15),
                new Student("Georgi",21),
                new Student("Hristo",7)
            };


            List<Student> listStudentsTwo = new List<Student>()
            {
                new Student("Milush",15),
                new Student("Ginka",21),
                new Student("Dimitar",7)
            };

            List<Disciplines> listDisciplineOne = new List<Disciplines>()
            {
                new Disciplines("Biologiq",21,listStudentsOne),
                new Disciplines("Angliiski",18,listStudentsTwo)
            };

            Teacher teacherOne = new Teacher("Penka",listDisciplineOne);
            Console.WriteLine(teacherOne);
            
        }
    }
}
