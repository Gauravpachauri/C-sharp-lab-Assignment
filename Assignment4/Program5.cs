using System;

class Car
{
    private int speed;

    public int Speed
    {
        get { return speed; }
        set
        {
            if (value > 180)
                speed = 180;
            else
                speed = value;
        }
    }
}

class Program5
{
    static void Main()
    {
        Car c = new Car();
        c.Speed = 150;
        Console.WriteLine("Speed set to 150 → " + c.Speed);

        c.Speed = 200;
        Console.WriteLine("Speed set to 200 → " + c.Speed);
    }
}