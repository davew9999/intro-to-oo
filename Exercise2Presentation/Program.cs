using System;

namespace Exercise2Presentation
{
    public class Cat
    {
        private readonly string Name;
        private readonly int Age;
        private readonly string Breed;

        public Cat(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        public string SayHello()
        {
            return $"Hi. My name is {Name} and I am {Age} years old";
        }
    }

    class Program
    {
        static void Main()
        {
            var cat = new Cat("Kitty", 6, "Persian");
            Console.WriteLine(cat.SayHello());
        }
    }
}