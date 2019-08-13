using IntroToOO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Exercise4Tests
    {
        [TestMethod]
        public void DiscountIsCorrectlyAppliedForPercentage()
        {
            var percentagePromotion = new Exercise4.PercentagePromotion("10Off", "Get 10% off", 10);
            decimal discountToApply = Exercise4.RunPromotion(percentagePromotion);
            Assert.AreEqual(20, discountToApply);
        }

        [TestMethod]
        public void DiscountIsCorrectlyAppliedForMoneyOff()
        {
            var moneyOffPromotion = new Exercise4.MoneyOffPromotion("£30Off", "Get £30 off", 30);
            decimal discountToApply = Exercise4.RunPromotion(moneyOffPromotion);
            Assert.AreEqual(30, discountToApply);
        }
    }
}