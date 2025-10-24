using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int accountNumber, string accountHolderName, double initialBalance = 0)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
            BankUtils.TotalAccounts++;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine(amount + " deposited successfully.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine(amount + " withdrawn successfully.");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }

        public void DisplayAccount()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Holder: " + AccountHolderName);
            Console.WriteLine("Balance: " + Balance);
            Console.WriteLine("-------------------------");
        }
    }

    static class BankUtils
    {
        public static int TotalAccounts { get; set; }

        public static void DisplayTotalAccounts()
        {
            Console.WriteLine("Total Bank Accounts: " + TotalAccounts);
        }
    }
    internal class Q2
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount(101, "Aman", 5000);
            BankAccount acc2 = new BankAccount(102, "Riya", 3000);

            acc1.DisplayAccount();
            acc2.DisplayAccount();

            acc1.Deposit(2000);
            acc2.Withdraw(1000);

            acc1.DisplayAccount();
            acc2.DisplayAccount();

            BankUtils.DisplayTotalAccounts();
        }
    }
}
