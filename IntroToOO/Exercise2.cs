namespace IntroToOO
{
    public static class Exercise2
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

            // These 3 lines of code should error!
            promotion.Code = "a new code!";
            promotion.Description = "a new description!";
            // Imagine somebody accidentally changed the code to give 100% off!
            promotion.Discount = 100;

            return promotion.Details();
        }
    }
}
