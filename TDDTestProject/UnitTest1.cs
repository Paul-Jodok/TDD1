using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCore;

namespace TDDTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.AreEqual(new Dollar(10), product);
            product = five.Times(3);
            Assert.AreEqual(new Dollar(15), product);
        }

        public void TestFrancMultiplication()
        {
            Franc five = new Franc(5);
            Franc product = five.Times(2);
            Assert.AreEqual(new Franc(10), product);
            product = five.Times(3);
            Assert.AreEqual(new Franc(15), product);            
        }

        public void TestEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
