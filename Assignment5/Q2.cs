using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Q2
    {
        static int counter;
        const int totalIncrements = 1_000_000;
        const int threadCount = 4;

        static void IncrementUnsafe(object? timesObj)
        {
            int times = (int)timesObj!;
            for (int i = 0; i < times; i++)
            {
                // race condition: read-modify-write is not atomic
                counter = counter + 1;
            }
        }

        static void IncrementSafe(object? timesObj)
        {
            int times = (int)timesObj!;
            for (int i = 0; i < times; i++)
            {
                Interlocked.Increment(ref counter);
            }
        }

        static void RunCase(string label, ParameterizedThreadStart work)
        {
            counter = 0;
            int perThread = totalIncrements / threadCount;
            Thread[] threads = new Thread[threadCount];

            for (int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(work);
                threads[i].Start(perThread);
            }
            foreach (var t in threads) t.Join();

            Console.WriteLine($"{label} counter = {counter}");
        }

        static void Main(string[] args)
        {
            RunCase("Without sync (expect < 1000000 due to lost updates):", IncrementUnsafe);
            RunCase("With Interlocked.Increment (expect 1000000):", IncrementSafe);

            Console.WriteLine("Developed By Utkarsh Roll-48");
        }
    }
}
