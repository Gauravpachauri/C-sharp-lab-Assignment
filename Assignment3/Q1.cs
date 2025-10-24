using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("----------------------");
        }
    }
    internal class Q1
    {

        static void Main(string[] args)
        {
            Employee emp1 = new Employee { Name = "Aman", Age = 28, Salary = 50000 };
            Employee emp2 = new Employee { Name = "Riya", Age = 25, Salary = 45000 };

            emp1.DisplayDetails();
            emp2.DisplayDetails();
        }
    }
}
