using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    using System;

    namespace PartialClassApp
    {
        public partial class Person
        {
            public void PrintFullName()
            {
                Console.WriteLine("Full Name: " + FirstName + " " + LastName);
            }
        }
    }

    internal class Q5a
    {
    }
}
