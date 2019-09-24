﻿namespace IntroToOO.PresentationCode.Exercise3
{
    public class Animal
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
    }
}
