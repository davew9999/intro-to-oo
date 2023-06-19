using System;

var promotion = new Promotion("10Off", "Get 10% off", 10);

//promotion.Code = "a new code!";
//promotion.Description = "a new description!";
//promotion.Discount = 100;

Console.WriteLine(promotion.Details());


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

    public string Details()
    {
        return $"Code: {Code}. Description: {Description}. Discount: {Discount}";
    }
}
