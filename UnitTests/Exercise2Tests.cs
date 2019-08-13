using IntroToOO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Exercise2Tests
    {
        [TestMethod]
        public void DiscountIsCorrectlyApplied()
        {
            string promotionDetails = Exercise2.Run();
            Assert.AreEqual("Type: Percent. Code: 10Off. Description: Get 10% off. Discount: 10", promotionDetails);
        }
    }
}
