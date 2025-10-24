using System;
class Employee
{
    private double basicSalary;
    public double BasicSalary
    {
        get { return basicSalary; }
        set { basicSalary = value; }
    }
    public double TotalSalary
    {
        get { return basicSalary + (0.2 * basicSalary); } // 20% bonus 
    }
}
class Program3
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.BasicSalary = 30000;
        Console.WriteLine("Total Salary: " + emp.TotalSalary);
    }
}