using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToOO.Complete
{
    public class Exercise2
    {
        public class Promotion
        {
            private readonly string Code;
            private readonly string Description;
            private readonly int Discount;

            public Promotion(string code, string description, int discount)
            {
                Code = code;
                Description = description;
                Discount = discount;
            }

            public string Details => $"Code: {Code}. Description: {Description}. Discount: {Discount}";
        }

        public static string Run()
        {
            var promotion = new Promotion("10Off", "Get 10% off", 10);

            //promotion.Code = "a new code!";
            //promotion.Description = "a new description!";
            //promotion.Discount = 100;

            return promotion.Details;
        }
    }
}
