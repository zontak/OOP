using System.Collections.Generic;

namespace CompanyHierarchy
{
    public interface IPersonInterface
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int ID { get; set; }
    }

    public interface IEmployeeInterface
    {
        decimal Salary { get; set; }
        DepartmentEmployee Department { get; set; }
    }

    public interface IManagerInterface
    {
        List<Employee> Employees { get; set; }
    }

    public interface ICostumerInterface
    {
        decimal TotalAmountOfMoney { get; set; }
    }

    public interface ISalesEmployeeInterface
    {
        List<Sale> Sales { get; set; }
    }

    public interface IDeveloperInterface
    {
        List<Project> Projects { get; set; }
    }
}
