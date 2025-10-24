using System;
using System.Collections.Generic;

class Q10
{
    static void Main()
    {
        int[] dataset1 = { 1, 2, 3, 4, 5 };
        int[] dataset2 = { 3, 4, 5, 6, 7 };
        List<int> commonElements = new List<int>();

        for (int i = 0; i < dataset1.Length; i++)
        {
            for (int j = 0; j < dataset2.Length; j++)
            {
                if (dataset1[i] == dataset2[j] && !commonElements.Contains(dataset1[i]))
                {
                    commonElements.Add(dataset1[i]);
                }
            }
        }

        Console.WriteLine("Common elements:");
        foreach (int element in commonElements)
        {
            Console.Write(element + " ");
        }
    }
}
