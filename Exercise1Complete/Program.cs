using System;

namespace Exercise1Complete
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

    class Program
    {
        static void Main()
        {
            var promotion = new Promotion {Code = "10Off", Description = "Get 10% off", Discount = 10};
            Console.WriteLine(promotion.Details());
        }
    }
}
