using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
    }

    internal class Q3
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("int, int: " + calc.Add(5, 10));
            Console.WriteLine("int, int, int: " + calc.Add(1, 2, 3));
            Console.WriteLine("float, float: " + calc.Add(2.5f, 3.7f));
            Console.WriteLine("double, double: " + calc.Add(4.5, 6.3));
            Console.WriteLine("double, double, double: " + calc.Add(1.1, 2.2, 3.3));
        }
    }
}
