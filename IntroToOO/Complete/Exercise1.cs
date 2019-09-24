namespace IntroToOO.Complete
{
    public static class Exercise1
    {
        public class Promotion
        {
            public string Code;
            public string Description;
            public int Discount;

            public string Details() 
            {
                return $"Code: {Code}. Description: {Description}. Discount: {Discount}";
            }
        }

        public static string Run()
        {
            var promotion = new Promotion{Code = "10Off", Description = "Get 10% off", Discount = 10};
            return promotion.Details();
        }
    }
}