using System;

class Q4
{
    static void Main()
    {
        int[] participantCodes = { 102, 215, 324, 453, 536 };
        int maleCount = 0;
        int femaleCount = 0;

        for (int i = 0; i < participantCodes.Length; i++)
        {
            if (participantCodes[i] % 2 == 0)
            {
                maleCount++;
            }
            else
            {
                femaleCount++;
            }
        }

        Console.WriteLine("Number of male participants: " + maleCount);
        Console.WriteLine("Number of female participants: " + femaleCount);
    }
}
