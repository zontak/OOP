using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace HumanStudentAndWorker
{
    class HumanStudentAndWorker
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("123456789","Hristo","Ivanov"),
                new Student("65317232", "Dimitar", "Bonev"),
                new Student("32747832", "Kristiqn", "Petrov"),
                new Student("12342332", "Misho", "Hristov"),
                new Student("36234244", "Stoqn", "Dragulov"),
                new Student("23423412","Georgi","Georgiev"),
                new Student("562324532", "Ivan", "Shishkan"),
                new Student("23423432", "Dragan", "Smirnenski"),
                new Student("344576574", "Georgi", "Ivanov"),
                new Student("87636345", "Pesho", "Peshev")
            };

            var sortByFacultyNumber =
                from student in studentList
                orderby student.FacultyNumber
                select student;

            //foreach (var student in sortByFacultyNumber)
            //{
            //    Console.WriteLine("Frist Name: " + student.FirstName + ", Last Name: " + student.LastName + ", Faculty Number: " + student.FacultyNumber);
            //}


            Worker workerOne = new Worker("Minka","Prostitutkata",50,10);
            //Console.WriteLine(workerOne.MoneyPerHour());

            

            List<Worker> workerList = new List<Worker>()
            {
                new Worker("Minka","Prostitutkata",123,10),
                new Worker("Sashka","Prostakesa",5120,10),
                new Worker("Ginka","Shishmanova",54560,10),
                new Worker("Desislava","Samarinova",5567450,10),
                new Worker("Ivanka","Petrova",52450,10),
                new Worker("Dragana","Georgieva",502,10),
                new Worker("Maria","Samarinova",57850,10),
                new Worker("Deqna","Georgieva",7550,10),
                new Worker("Viktoriq","Veselinova",42350,10),
                new Worker("Petkana","Rostislavova",243550,10)
            };

            // Concat two list 
            List<Human> humans = new List<Human>();

            foreach (var list1 in workerList)
            {
                humans.Add(list1);
            }
            foreach (var student in studentList)
            {
                humans.Add(student);
            }

            var sortByName =
                from human in humans
                orderby human.FirstName
                select human.FirstName + " " + human.LastName;

            foreach (var human in sortByName)
            {
                Console.WriteLine(human);
            }
           

        }

    }
}
