using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToOO.Complete
{
    public class Exercise4
    {
        public abstract class Promotion
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

            public string Details => $"Code: {Code}. Description: {Description}. Discount: {Discount}";

            public abstract decimal DiscountToApply(decimal price);
        }

        public class PercentagePromotion : Promotion
        {
            public PercentagePromotion(string code, string description, int discount) : base(code, description, discount)
            {
            }

            public override decimal DiscountToApply(decimal price)
            {
                return price * (Discount / 100m);
            }
        }

        public class MoneyOffPromotion : Promotion
        {
            public MoneyOffPromotion(string code, string description, int discount) : base(code, description, discount)
            {
            }

            public override decimal DiscountToApply(decimal price)
            {
                return Discount;
            }
        }

        public static decimal RunPromotion(Promotion promotion)
        {
            decimal productPrice = 200;
            return promotion.DiscountToApply(productPrice);
        }
    }
}