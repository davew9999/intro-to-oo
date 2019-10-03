using System;

namespace Exercise4
{
    class Program
    {
        public class Promotion
        {
            protected readonly string Code;
            protected readonly string Description;
            protected readonly int Discount;

            public Promotion(string code, string description, int discount)
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

        public static decimal RunPromotion(Promotion promotion)
        {
            decimal productPrice = 200;

            // I want to be able to write the line below, but it doesn't know which DiscountToApply method to use!
            //return promotion.DiscountToApply(productPrice);

            // We have to write this, not nice!
            if (promotion is PercentagePromotion percentagePromotion)
            {
                return percentagePromotion.DiscountToApply(productPrice);
            }

            if (promotion is MoneyOffPromotion moneyOffPromotion)
            {
                return moneyOffPromotion.DiscountToApply(productPrice);
            }

            throw new Exception("Don't know how to handle this type of promotion!");
        }

        static void Main()
        {
            var percentagePromotion = new PercentagePromotion("10Off", "Get 10% off", 10);
            Console.WriteLine("PercentagePromotion: " + RunPromotion(percentagePromotion));

            var moneyOffPromotion = new MoneyOffPromotion("£30Off", "Get £30 off", 30);
            Console.WriteLine("MoneyOffPromotion: " + RunPromotion(moneyOffPromotion));
        }
    }
}