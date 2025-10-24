using System;

class Q1
{
    static void Main()
    {
        int[] transactions = { 200, -150, 340, 500, -100 };
        int sum = 0;

        for (int i = 0; i < transactions.Length; i++)
        {
            sum += transactions[i];
        }

        Console.WriteLine("Total sum of all transactions: " + sum);
    }
}
