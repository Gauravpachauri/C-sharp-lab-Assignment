using System;

class Q3
{
    static void Main()
    {
        int[] prices = { 1500, 2300, 999, 3200, 1750 };
        int max = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > max)
            {
                max = prices[i];
            }
        }

        Console.WriteLine("The most expensive item costs: " + max);
    }
}
