using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Product
    {
        private int productID;
        private string productName;
        private double price;
        private int quantity;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Invalid price. Price cannot be negative.");
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                    quantity = value;
                else
                    Console.WriteLine("Invalid quantity. Quantity cannot be negative.");
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine("ProductID: " + ProductID +
                              ", Name: " + ProductName +
                              ", Price: " + Price +
                              ", Quantity: " + Quantity);
        }
    }
    internal class Q6
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.ProductID = 101;
            p1.ProductName = "Laptop";
            p1.Price = 55000;
            p1.Quantity = 10;

            p1.PrintDetails();
        }
    }
}
