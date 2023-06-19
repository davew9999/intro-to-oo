using System;

decimal productPrice = 200;
var percentagePromotion = new PercentagePromotion("10Off", "Get 10% off", 10);
Console.WriteLine("PercentagePromotion: " + percentagePromotion.DiscountToApply(productPrice));

var moneyOffPromotion = new MoneyOffPromotion("£30Off", "Get £30 off", 30);
Console.WriteLine("MoneyOffPromotion: " + moneyOffPromotion.DiscountToApply(productPrice));


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