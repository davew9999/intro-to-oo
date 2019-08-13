namespace IntroToOO
{
    public static class Exercise2
    {
        public class Promotion
        {
            public PromotionType Type;
            public string Code;
            public string Description;
            public int Discount;

            public string Details => $"Type: {Type}. Code: {Code}. Description: {Description}. Discount: {Discount}";
        }

        public static string Run()
        {
            var promotion = new Promotion{Type = PromotionType.Percent, Code = "10Off", Description = "Get 10% off", Discount = 10};

            // These 4 lines of code should error!
            promotion.Type = PromotionType.MoneyOff;
            promotion.Code = "a new code!";
            promotion.Description = "a new description!";
            // Imagine somebody accidentally changed the code to give 100% off!
            promotion.Discount = 100;

            return promotion.Details;
        }
    }
}
