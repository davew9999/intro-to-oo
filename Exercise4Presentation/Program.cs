﻿using System;

namespace Exercise4Presentation
{
    public abstract class Animal
    {
        private readonly string Name;
        private readonly int Age;
        private readonly string Breed;

        public Animal(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        public string SayHello()
        {
            return $"Hi. My name is {Name} and I am {Age} years old";
        }

        public abstract string WhatAreYou();
    }

    public class Cat : Animal
    {
        public Cat(string name, int age, string breed) : base(name, age, breed)
        {
        }

        public override string WhatAreYou()
        {
            return "I'm a cat!";
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, int age, string breed) : base(name, age, breed)
        {
        }

        public override string WhatAreYou()
        {
            return "I'm a dog!";
        }
    }

    class Program
    {
        public string WhatAreYou(Animal animal)
        {
            return animal.WhatAreYou();
        }

        static void Main(string[] args)
        {
            var cat = new Cat("Kitty", 6, "Persian");
            var dog = new Dog("Walter", 4, "Jack Russell Terrier");
            Console.WriteLine("Cat: " + cat.WhatAreYou());
            Console.WriteLine("Dog: " + dog.WhatAreYou());
        }
    }
}
