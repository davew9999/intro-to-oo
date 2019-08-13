using IntroToOO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Exercise1Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string output = Exercise1.Run();
            Assert.AreEqual("Type: Percent. Code: 10Off. Description: Get 10% off. Discount: 10", output);
        }
    }
}
