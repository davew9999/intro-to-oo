using System;

namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            const string promotionCode = "10Off";
            const string promotionDescription = "Get 10% off";
            const int promotionDiscount = 10;

            Console.WriteLine(
                $"Code: {promotionCode}. Description: {promotionDescription}. Discount: {promotionDiscount}");
        }
    }
}
