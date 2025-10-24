using System;

delegate int Operation(int a, int b);

class Program6
{
    static int Add(int x, int y) => x + y;
    static int Subtract(int x, int y) => x - y;

    static void Main()
    {
        Console.Write("Enter first number: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int n2 = int.Parse(Console.ReadLine());

        Operation op = Add;
        Console.WriteLine("Addition: " + op(n1, n2));

        op = Subtract;
        Console.WriteLine("Subtraction: " + op(n1, n2));
    }
}