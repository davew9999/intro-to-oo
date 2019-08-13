using IntroToOO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Exercise3Tests
    {
        [TestMethod]
        public void DiscountIsCorrectlyAppliedForPercentage()
        {
            decimal discountToApply = Exercise3.RunPercentagePromotion();
            Assert.AreEqual(20, discountToApply);
        }

        [TestMethod]
        public void DiscountIsCorrectlyAppliedForMoneyOff()
        {
            decimal discountToApply = Exercise3.RunMoneyOffPromotion();
            Assert.AreEqual(30, discountToApply);
        }
    }
}