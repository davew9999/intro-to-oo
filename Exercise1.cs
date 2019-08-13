using System;

namespace IntroToOO
{
    public static class Exercise1
    {
        public static string Run()
        {
            const PromotionType promotionType = PromotionType.Percent;
            const string promotionCode = "10Off";
            const string promotionDescription = "Get 10% off";
            const int promotionDiscount = 10;

            return
                $"Type: {promotionType}. Code: {promotionCode}. Description: {promotionDescription}. Discount: {promotionDiscount}";
        }
    }
}
