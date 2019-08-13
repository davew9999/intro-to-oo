using IntroToOO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Exercise2Tests
    {
        [TestMethod]
        public void PromotionDetailsAreCorrect()
        {
            string promotionDetails = Exercise2.Run();
            Assert.AreEqual("Code: 10Off. Description: Get 10% off. Discount: 10", promotionDetails);
        }
    }
}
