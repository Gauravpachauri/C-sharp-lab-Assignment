using System;

namespace Assignment2
{
    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }

    class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }

        public Truck(string make, string model, int year, int loadCapacity)
            : base(make, model, year)
        {
            LoadCapacity = loadCapacity;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Truck: " + Year + " " + Make + " " + Model +
                ", Load Capacity: " + LoadCapacity + " tons");
        }
    }

    class Bus : Vehicle
    {
        public int SeatingCapacity { get; set; }

        public Bus(string make, string model, int year, int seatingCapacity)
            : base(make, model, year)
        {
            SeatingCapacity = seatingCapacity;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Bus: " + Year + " " + Make + " " + Model +
                ", Seating Capacity: " + SeatingCapacity + " seats");
        }
    }

    class Q2
    {
        static void Main(string[] args)
        {
            Truck truck1 = new Truck("Volvo", "FH16", 2022, 25);
            Bus bus1 = new Bus("Mercedes", "Citaro", 2021, 50);

            truck1.DisplayDetails();
            bus1.DisplayDetails();
        }
    }
}
