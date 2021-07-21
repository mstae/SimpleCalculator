using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DemoCalculatorApp;

namespace AppUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            CalculatorLogic c1 = new CalculatorLogic();
            double expectedResult = 16;
            double actualResult = c1.SimpleAddition(8, 8);
            Assert.AreEqual(expectedResult, actualResult);

            expectedResult = 20;
            actualResult = c1.SimpleMultiplication(5, 4);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestSubtraction()
        {
            CalculatorLogic c1 = new CalculatorLogic();
            double expectedResult = 8;
            double actualResult = c1.SimpleSubtraction(9, 1);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            CalculatorLogic c1 = new CalculatorLogic();
            double expectedResult = 20;
            double actualResult = c1.SimpleMultiplication(5, 4);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDivision()
        {
            CalculatorLogic c1 = new CalculatorLogic();
            double expectedResult = 5;
            double actualResult = c1.SimpleDivision(20, 4);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestRemainder()
        {
            CalculatorLogic c1 = new CalculatorLogic();
            double expectedResult = 2;
            double actualResult = c1.SimpleRemainder(17, 5);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
