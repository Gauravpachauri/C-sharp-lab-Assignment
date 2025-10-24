using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Q5b
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { FirstName = "Aman", LastName = "Sharma" };
            Person p2 = new Person { FirstName = "Riya", LastName = "Verma" };

            p1.PrintFullName();
            p2.PrintFullName();
        }
    }
}
