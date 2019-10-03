namespace Exercise3.PresentationCode
{
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
}
