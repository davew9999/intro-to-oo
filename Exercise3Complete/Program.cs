using System;

namespace Exercise3Complete
{
    class Program
    {
        public class Promotion
        {
            protected readonly string Code;
            protected readonly string Description;
            protected readonly int Discount;

            protected Promotion(string code, string description, int discount)
            {
                Code = code;
                Description = description;
                Discount = discount;
            }
            
            public string Details() 
            {
                return $"Code: {Code}. Description: {Description}. Discount: {Discount}";
            }
        }

        public class PercentagePromotion : Promotion
        {
            public PercentagePromotion(string code, string description, int discount) : base(code, description, discount)
            {
            }

            public decimal DiscountToApply(decimal price)
            {
                return price * (Discount / 100m);
            }
        }

        public class MoneyOffPromotion : Promotion
        {
            public MoneyOffPromotion(string code, string description, int discount) : base(code, description, discount)
            {
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
            Console.WriteLine("PercentagePromotion: " + promotion.DiscountToApply(productPrice));

        }

        public static void RunMoneyOffPromotion()
        {
            decimal productPrice = 200;
            var promotion = new MoneyOffPromotion("£30Off", "Get £30 off", 30);
            Console.WriteLine("MoneyOffPromotion: " + promotion.DiscountToApply(productPrice));
        }

        static void Main()
        {
            RunPercentagePromotion();
            RunMoneyOffPromotion();
        }
    }
}
