using System;

class BankAccount
{
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
        private set { balance = value; }  // deposit allowed internally 
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= Balance)
            Balance -= amount;
        else
            Console.WriteLine("Insufficient balance!");
    }
}

class Program1
{
    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.Deposit(1000);
        Console.WriteLine("After deposit: " + acc.Balance);

        acc.Withdraw(500);
        Console.WriteLine("After withdrawal: " + acc.Balance);
    }
}