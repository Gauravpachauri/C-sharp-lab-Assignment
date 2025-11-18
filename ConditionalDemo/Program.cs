using System;
using System.Diagnostics;  

namespace ConditionalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Started: RADHEY RADHEY");
            ShowDebugMessage();
            Console.WriteLine("Program Ended: JAY SHRI KRISHNA");
            Console.ReadLine();
        }

        [Conditional("DEBUG")]
        static void ShowDebugMessage()
        {
            Console.WriteLine("DEBUG: yah  message dikhega Debug mode me dikhega.");
        }
    }
}
