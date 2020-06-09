using System;

namespace Exercise1Presentation
{
    public class Cat
    {
        public string Name;
        public int Age;
        public string Breed;

        public string SayHello()
        {
            return $"Hi. My name is {Name} and I am {Age} years old";
        }
    }

    class Program
    {
        static void Main()
        {
            var cat = new Cat {Age = 6, Breed = "Persian", Name = "Kitty"};
            Console.WriteLine(cat.SayHello());
        }
    }
}
