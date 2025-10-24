using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Student
    {
        private string name;
        private int rollNumber;
        private double marks;

        public Student()
        {
            name = "Unknown";
            rollNumber = 0;
            marks = 0.0;
        }

        public Student(string name, int rollNumber)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            marks = 0.0;
        }

        public Student(string name, int rollNumber, double marks)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.marks = marks;
        }

        public void DisplayData()
        {
            Console.WriteLine("Name: " + name + ", Roll No: " + rollNumber + ", Marks: " + marks);
        }
    }
    internal class Q5
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("Aman", 101);
            Student s3 = new Student("Ankit", 102, 88.5);

            Console.WriteLine("Student Records:");
            s1.DisplayData();
            s2.DisplayData();
            s3.DisplayData();
        }
    }
}
