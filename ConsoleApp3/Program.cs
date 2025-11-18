using System;

namespace ObsoleteDemo
{
    class Program
    {
        // Old method marked as obsolete
        [Obsolete("Use NewGreet() instead. OldGreet is deprecated!", false)]
        static void OldGreet()
        {
            Console.WriteLine("Hello from the OLD method.");
        }

        // New recommended method
        static void NewGreet()
        {
            Console.WriteLine("Hello from the NEW method.");
        }

        static void Main(string[] args)
        {
            OldGreet();    // This will show a WARNING in Visual Studio!
            NewGreet();    // No warning, use this one
            Console.ReadLine();
        }
    }
}
