using System;

class Q5
{
    static void Main()
    {
        int[] searchHistory = { 101, 202, 303, 404, 505 };
        int n = searchHistory.Length;

        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(searchHistory[i] + " ");
        }
    }
}
