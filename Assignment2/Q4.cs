using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    abstract class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public abstract double CalculateSalary();
    }

    class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public FullTimeEmployee(string name, double monthlySalary)
            : base(name)
        {
            MonthlySalary = monthlySalary;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(string name, double hourlyRate, int hoursWorked)
            : base(name)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
    internal class Q4
    {
        static void Main(string[] args)
        {
            FullTimeEmployee emp1 = new FullTimeEmployee("Aman", 50000);
            Console.WriteLine(emp1.Name + "'s Salary = " + emp1.CalculateSalary());

            PartTimeEmployee emp2 = new PartTimeEmployee("Riya", 500, 80);
            Console.WriteLine(emp2.Name + "'s Salary = " + emp2.CalculateSalary());
        }
    }
}
