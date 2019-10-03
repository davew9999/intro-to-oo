using System;

namespace Exercise3
{
    class Program
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
        public static void RunPercentagePromotion()
        {
            decimal productPrice = 200;
            var promotion = new PercentagePromotion("10Off", "Get 10% off", 10);
            Console.WriteLine(promotion.DiscountToApply(productPrice));
        }

        public static void RunMoneyOffPromotion()
        {
            decimal productPrice = 200;
            var promotion = new MoneyOffPromotion("£30Off", "Get £30 off", 30);
            Console.WriteLine(promotion.DiscountToApply(productPrice));
        }

        static void Main(string[] args)
        {
            if (args.Length != 1) return;
            string methodToRun = args[0];
            if (methodToRun == "Percentage")
            {
                RunPercentagePromotion();
            }
            else if (methodToRun == "MoneyOff")
            {
                RunMoneyOffPromotion();
            }
        }
    }
}