using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            JuniorTrainer gosho = new JuniorTrainer("gosho", "goshev", 23);
            gosho.CreateCourse("C#");
            SeniorTrainer pesho = new SeniorTrainer("pesho", "peshev", 23);
            pesho.CreateCourse("OOP");
            pesho.DeleteCourse("OOP");
            DropoutStudent sashka = new DropoutStudent("sashka", "vaseva", 55, 1234567890, 5.65, "I do not know...");
            sashka.Reapply();
            OnsideStudent tasho = new OnsideStudent("tasho", "tashev", 19, 1234567890, 5.00, "Java", 13);
            OnlineStudent veso = new OnlineStudent("vese", "veseloto", 33, 1234567890, 2.20, "JavaScript");
            OnsideStudent ceko = new OnsideStudent("ceko", "cekov", 19, 1234567890, 4.00, "PHP", 5);
            OnlineStudent stamat = new OnlineStudent("stamat", "stamatov", 33, 1234567890, 5.35, "JavaScript");
            List<Object> people = new List<Object>();
            people.Add(gosho);
            people.Add(pesho);
            people.Add(sashka);
            people.Add(tasho);
            people.Add(veso);
            people.Add(ceko);
            people.Add(stamat);
            people.Where(p => p is CurrentStudent).OrderBy(p => ((CurrentStudent)p).AverageGrade).ToList()
            .ForEach(p => Console.WriteLine(((CurrentStudent)p).FirstName + " " + ((CurrentStudent)p).LastName + " " + ((CurrentStudent)p).AverageGrade));
        }
    }
}
