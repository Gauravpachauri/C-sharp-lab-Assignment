using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            return (double)sum / numbers.Length;
        }
    }
    internal class Q3
    {
        static void Main(string[] args)
        {
            int[] scores = { 85, 90, 78, 88, 92 };
            double average = MathHelper.CalculateAverage(scores);

            Console.WriteLine("Average: " + average);
        }
    }
}
