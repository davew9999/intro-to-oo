using System;

var cat = new Cat("Kitty", 6, "Persian");
var dog = new Dog("Walter", 4, "Jack Russell Terrier");
Console.WriteLine("Cat: " + cat.WhatAreYou());
Console.WriteLine("Dog: " + dog.WhatAreYou());

public class Animal
{
    protected readonly string Name;
    protected readonly int Age;
    protected readonly string Breed;

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

public class Cat : Animal
{
    public Cat(string name, int age, string breed) : base(name, age, breed)
    {
    }

    public string WhatAreYou()
    {
        return "I'm a cat!";
    }
}

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