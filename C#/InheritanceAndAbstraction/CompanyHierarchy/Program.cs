using System.Collections.Generic;
using System;

namespace CompanyHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {

            Costumer costumer = new Costumer("Minka", "Georgieva", 40, 3000);

            DepartmentEmployee department = new DepartmentEmployee(Department.Accounting);
            DepartmentEmployee departmentTwo = new DepartmentEmployee(Department.Marketing);

            DateTime date = new DateTime();
            date = DateTime.Now;

            List<Project> projects = new List<Project>()
            {
                new Project("Anatomiq",date,"This is details,blaa",State.open),
                new Project("Biologiq",date,"Detailsssss",State.closed)
            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee("Petar","Petrov",22,200,department),
                new Employee("Georgi","Georgiev",17,400,departmentTwo)

            };

            List<Sale> saleEmployeeList = new List<Sale>()
            {
                new Sale("Mikrovylnova", date, 1200),
                new Sale("Klimatik", date,4000)
            };

            Employee employeOne = new Employee("Georgi", "Georgiev", 50, 5000, department);
            SalesEmployee saleEmploye = new SalesEmployee(saleEmployeeList);
            Manager managerOne = new Manager("Ivan", "Geshev", 2, 20, department, employees);
            Developer developerOne = new Developer(projects);

            Console.WriteLine(developerOne);
            Console.WriteLine(managerOne);
            Console.WriteLine(costumer);
            Console.WriteLine(saleEmploye);
            Console.WriteLine(employeOne);
        }
    }
}
