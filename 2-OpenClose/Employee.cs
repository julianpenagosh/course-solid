using System.Runtime;

namespace OpenClosePrinciple
{
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public abstract decimal CalculateSalaryMonthly();
        

    }

}
