using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToOO.PresentationCode.Exercise4
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
}
