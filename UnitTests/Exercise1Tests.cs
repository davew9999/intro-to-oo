using IntroToOO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Exercise1Tests
    {
        [TestMethod]
        public void PromotionDetailsAreCorrect()
        {
            string promotionDetails = Exercise1.Run();
            Assert.AreEqual("Code: 10Off. Description: Get 10% off. Discount: 10", promotionDetails);
        }
    }
}
