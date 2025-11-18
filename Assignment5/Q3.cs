using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Q3
    {

        class Bank
        {
            private readonly object _guard = new object();
            private decimal _balance;

            public Bank(decimal opening) { _balance = opening; }

            // UNSAFE versions (race-prone)
            public void DepositUnsafe(decimal amount) { _balance = _balance + amount; }
            public void WithdrawUnsafe(decimal amount) { _balance = _balance - amount; }

            // lock-based safe versions
            public void DepositLocked(decimal amount)
            {
                lock (_guard)
                {
                    _balance = _balance + amount;
                }
            }
            public void WithdrawLocked(decimal amount)
            {
                lock (_guard)
                {
                    _balance = _balance - amount;
                }
            }

            // Monitor-based safe versions (with timeout)
            public void DepositMonitor(decimal amount, int timeoutMs = 100)
            {
                bool taken = false;
                try
                {
                    taken = Monitor.TryEnter(_guard, timeoutMs);
                    if (!taken) return; // skip if couldn't acquire
                    _balance = _balance + amount;
                }
                finally
                {
                    if (taken) Monitor.Exit(_guard);
                }
            }
            public void WithdrawMonitor(decimal amount, int timeoutMs = 100)
            {
                bool taken = false;
                try
                {
                    taken = Monitor.TryEnter(_guard, timeoutMs);
                    if (!taken) return;
                    _balance = _balance - amount;
                }
                finally
                {
                    if (taken) Monitor.Exit(_guard);
                }
            }

            public decimal Balance => _balance;
        }

        static void HammerUnsafe(Bank bank, int ops)
        {
            for (int i = 0; i < ops; i++)
            {
                bank.DepositUnsafe(1m);
                bank.WithdrawUnsafe(1m);
            }
        }

        static void HammerLocked(Bank bank, int ops)
        {
            for (int i = 0; i < ops; i++)
            {
                bank.DepositLocked(1m);
                bank.WithdrawLocked(1m);
            }
        }

        static void HammerMonitor(Bank bank, int ops)
        {
            for (int i = 0; i < ops; i++)
            {
                bank.DepositMonitor(1m);
                bank.WithdrawMonitor(1m);
            }
        }

        static void RunScenario(string label, Action<Bank, int> worker)
        {
            Console.WriteLine(label);
            var bank = new Bank(0m);
            int threadCount = 8;
            int opsPerThread = 100_000;

            Thread[] threads = new Thread[threadCount];
            for (int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(() => worker(bank, opsPerThread));
                threads[i].Start();
            }
            foreach (var t in threads) t.Join();

            Console.WriteLine("Final Balance = " + bank.Balance);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // (a) Data race (likely non-zero due to lost updates)
            RunScenario("(a) UNSYNCHRONIZED (race expected)", HammerUnsafe);

            // (b) Fixed with lock (should be 0)
            RunScenario("(b) SYNCHRONIZED with lock", HammerLocked);

            // (c) Fixed with Monitor.TryEnter/Exit (should be 0; if timeouts occur, minor drift possible)
            RunScenario("(c) SYNCHRONIZED with Monitor.TryEnter/Exit", HammerMonitor);

            Console.WriteLine("Developed By Utkarsh Roll-48");
        }
    }
}
