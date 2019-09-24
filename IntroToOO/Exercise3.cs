namespace IntroToOO
{
    public class Exercise3
    {
        public class PercentagePromotion
        {
            private readonly string Code;
            private readonly string Description;
            private readonly int Discount;

            public PercentagePromotion(string code, string description, int discount)
            {
                Code = code;
                Description = description;
                Discount = discount;
            }

            public string Details()
            {
                return $"Code: {Code}. Description: {Description}. Discount: {Discount}";
            }

            public decimal DiscountToApply(decimal price)
            {
                return price * (Discount / 100m);
            }
        }

        public class MoneyOffPromotion
        {
            private readonly string Code;
            private readonly string Description;
            private readonly int Discount;

            public MoneyOffPromotion(string code, string description, int discount)
            {
                Code = code;
                Description = description;
                Discount = discount;
            }

            public string Details()
            {
                return $"Code: {Code}. Description: {Description}. Discount: {Discount}";
            }

            public decimal DiscountToApply(decimal price)
            {
                return Discount;
            }
        }

        public static decimal RunPercentagePromotion()
        {
            decimal productPrice = 200;
            var promotion = new PercentagePromotion("10Off", "Get 10% off", 10);
            return promotion.DiscountToApply(productPrice);

        }

        public static decimal RunMoneyOffPromotion()
        {
            decimal productPrice = 200;
            var promotion = new MoneyOffPromotion("£30Off", "Get £30 off", 30);
            return promotion.DiscountToApply(productPrice);
        }
    }
}
