namespace Exercise4.PresentationCode
{
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
}
