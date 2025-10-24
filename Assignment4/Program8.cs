using System;

delegate double BillingOperation(double amount);

class Program8
{
    static double ShowTotal(double amount)
    {
        Console.WriteLine("Original Price: " + amount);
        return amount;
    }

    static double ApplyDiscount(double amount)
    {
        double discounted = amount - (amount * 0.10);
        Console.WriteLine("After Discount: " + discounted);
        return discounted;
    }

    static double AddTax(double amount)
    {
        double taxed = amount + (amount * 0.18);
        Console.WriteLine("After Tax: " + taxed);
        return taxed;
    }

    static double FinalBill(double amount)
    {
        Console.WriteLine("Final Bill: " + amount);
        return amount;
    }

    static void Main()
    {
        double price = 5000;

        double amt = ShowTotal(price);
        amt = ApplyDiscount(amt);
        amt = AddTax(amt);
        FinalBill(amt);
    }
}

