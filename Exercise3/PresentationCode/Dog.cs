namespace Exercise3.PresentationCode
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string breed) : base(name, age, breed)
        {
        }

        public string WhatAreYou()
        {
            return "I'm a dog!";
        }
    }
}
