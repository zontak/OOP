using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }     
            set { this.workHoursPerDay = value; }
        }

        public Worker(string firstName, string lastName,decimal weekSalary, int workHoursPerDay ) :
            base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = (this.weekSalary/5)/this.workHoursPerDay;
            return moneyPerHour;
        }
    }
}
