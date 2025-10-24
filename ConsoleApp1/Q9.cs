using System;
using System.Collections.Generic;

class Q9
{
    static void Main()
    {
        int[] ids = { 102, 215, 102, 324, 215 };
        List<int> uniqueIds = new List<int>();

        for (int i = 0; i < ids.Length; i++)
        {
            if (!uniqueIds.Contains(ids[i]))
            {
                uniqueIds.Add(ids[i]);
            }
        }

        Console.WriteLine("Unique IDs:");
        foreach (int id in uniqueIds)
        {
            Console.Write(id + " ");
        }
    }
}
