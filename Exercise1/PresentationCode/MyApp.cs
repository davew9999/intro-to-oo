namespace Exercise1.PresentationCode
{
    public class MyApp
    {
        public string SayHelloCat()
        {
            var cat = new Cat {Age = 6, Breed = "Persian", Name = "Kitty"};
            return cat.SayHello();
        }
    }
}
