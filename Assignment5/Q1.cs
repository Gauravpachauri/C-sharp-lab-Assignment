using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Q1
    {

        static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
                Thread.Sleep(200);
            }
            Console.WriteLine();
        }

        static void PrintLetters()
        {
            for (char c = 'A'; c <= 'J'; c++)
            {
                Console.Write(c + " ");
                Thread.Sleep(300);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Thread tA = new Thread(PrintNumbers);
            Thread tB = new Thread(PrintLetters);

            tA.Start();
            tB.Start();

            tA.Join();
            tB.Join();

            Console.WriteLine("Both threads finished.");
            Console.WriteLine("Developed By Utkarsh Roll-48");
        }
    }
}
