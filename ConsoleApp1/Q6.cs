using System;

class Q6
{
    static void Main()
    {
        int[] measurements = { 2, 4, 6, 8 };
        int factor = 3;

        for (int i = 0; i < measurements.Length; i++)
        {
            measurements[i] *= factor;
        }

        Console.WriteLine("Adjusted measurements:");
        for (int i = 0; i < measurements.Length; i++)
        {
            Console.Write(measurements[i] + " ");
        }
    }
}
