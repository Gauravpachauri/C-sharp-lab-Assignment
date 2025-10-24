using System;

class Student
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 5 && value <= 25)
                age = value;
            else
                age = 18; // default 
        }
    }
}

class Program2
{
    static void Main()
    {
        Student s1 = new Student { Age = 4 };
        Console.WriteLine("Age set to 4 → " + s1.Age);
        Student s2 = new Student { Age = 20 };
        Console.WriteLine("Age set to 20 → " + s2.Age);
        Student s3 = new Student { Age = 30 };
        Console.WriteLine("Age set to 30 → " + s3.Age);
    }
}