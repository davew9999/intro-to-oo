namespace Exercise1.PresentationCode
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
}
