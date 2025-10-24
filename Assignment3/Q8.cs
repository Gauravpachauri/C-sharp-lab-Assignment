using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " says: Woof Woof");
        }

        public void Fetch()
        {
            Console.WriteLine(Name + " is fetching the ball.");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " says: Meow Meow");
        }

        public void Scratch()
        {
            Console.WriteLine(Name + " is scratching the post.");
        }
    }
    internal class Q8
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy", 3);
            Cat cat = new Cat("Whiskers", 2);

            dog.MakeSound();
            dog.Fetch();

            cat.MakeSound();
            cat.Scratch();
        }
    }
}
