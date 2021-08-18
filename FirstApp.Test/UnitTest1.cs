using Microsoft.VisualStudio.TestTools.UnitTesting;

using FirstApp.Models;

namespace FirstApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        MathCalculator Calculator; 
        public UnitTest1()
        {
            Calculator = new MathCalculator();
        }

        [TestMethod]
        public void AddValues_Test()
        {
            int val = Calculator.AddValues(10, 20);
            Assert.AreEqual(val, 30);
        }
        [TestMethod]
        public void SubtractValues_Test()
        {
            int val = Calculator.SubtractValues(10, 20);
            Assert.AreEqual(val, -10);
        }
        [TestMethod]
        public void MultiplyValues_Test()
        {
            int val = Calculator.MultiplyValues(10, 20);
            Assert.AreEqual(val, 200);
        }
    }
}
