using System;

namespace LoggerApp
{
    // Static Logger class
    static class Logger
    {
        public static void LogMessage(string message)
        {
            Console.WriteLine("[LOG] " + message);
        }
    }

    // Partial Program class - Part 1
    partial class Program
    {
        static void GreetUser(string name)
        {
            Logger.LogMessage("Greeting user: " + name);
            Console.WriteLine("Hello, " + name + "!");
        }
    }

    // Partial Program class - Part 2
    partial class Program
    {
        static void Main(string[] args)
        {
            Logger.LogMessage("Application Started");

            GreetUser("Aman");
            GreetUser("Riya");

            Logger.LogMessage("Application Ended");
        }
    }
}
