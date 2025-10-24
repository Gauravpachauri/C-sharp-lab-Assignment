using System;

delegate string FormatText(string input);

class Program7
{
    static string ToUpperCase(string s) => s.ToUpper();
    static string ToLowerCase(string s) => s.ToLower();

    static void Main()
    {
        string input = "Hello World";

        FormatText ft = ToUpperCase;
        Console.WriteLine("Uppercase: " + ft(input));

        ft = ToLowerCase;
        Console.WriteLine("Lowercase: " + ft(input));
    }
}