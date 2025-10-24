using System;

class Q2
{
    static void Main()
    {
        float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
        float sum = 0;

        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }

        float average = sum / scores.Length;
        Console.WriteLine("Average score of the class: " + average);
    }
}
