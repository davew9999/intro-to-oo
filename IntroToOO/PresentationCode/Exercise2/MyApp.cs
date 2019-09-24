namespace IntroToOO.PresentationCode.Exercise2
{
    public class MyApp
    {
        public string SayHelloCat()
        {
            var cat = new Cat("Kitty", 6, "Persian");
            return cat.SayHello();
        }
    }
}
