using System;

class Q8
{
    static void Main()
    {
        int[] grades = { 56, 78, 89, 45, 67 };
        int n = grades.Length;

        
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (grades[j] > grades[j + 1])
                {
                    int temp = grades[j];
                    grades[j] = grades[j + 1];
                    grades[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Second smallest grade is: " + grades[1]);
    }
}
