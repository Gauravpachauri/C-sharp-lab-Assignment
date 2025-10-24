using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Vehicle
    {
        public void StartEngine() => Console.WriteLine("Engine started");
        public void StopEngine() => Console.WriteLine("Engine stopped");
    }

    public sealed class Car : Vehicle
    {
        public void Drive() => Console.WriteLine("Car is driving...");
    }
    // ❌ This will cause an error because Car is sealed 
    /* 
    public class SportsCar : Car { } 
    */
    internal class Q9
    {
        static void Main()
        {
            Car c = new Car();
            c.StartEngine();
            c.Drive();
            c.StopEngine();
        }
}
