using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToOO.PresentationCode.Exercise4
{
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
}
