using System;

var percentagePromotion = new PercentagePromotion("10Off", "Get 10% off", 10);
Console.WriteLine("PercentagePromotion: " + RunPromotion(percentagePromotion));

var moneyOffPromotion = new MoneyOffPromotion("£30Off", "Get £30 off", 30);
Console.WriteLine("MoneyOffPromotion: " + RunPromotion(moneyOffPromotion));

static decimal RunPromotion(Promotion promotion)
{
    decimal productPrice = 200;
    return promotion.DiscountToApply(productPrice);
}


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

    public string Details()
    {
        return $"Code: {Code}. Description: {Description}. Discount: {Discount}";
    }

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