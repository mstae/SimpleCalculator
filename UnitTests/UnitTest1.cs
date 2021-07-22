using System;
using Xunit;
using DemoCalculatorApp;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddition()
        {
            CalculatorLogic c1 = new CalculatorLogic();
            double expectedResult = 16;
            double actualResult = c1.SimpleAddition(8, 8);
            Assert.Equal(expectedResult, actualResult);

            expectedResult = 20;
            actualResult = c1.SimpleMultiplication(5, 4);
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void TestSubtraction()
        {
            CalculatorLogic c1 = new CalculatorLogic();
            double expectedResult = 6;
            double actualResult = c1.SimpleSubtraction(9, 3);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestMultiplication()
        {
            CalculatorLogic c1 = new CalculatorLogic();
            double expectedResult = 20;
            double actualResult = c1.SimpleMultiplication(5, 4);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestDivision()
        {
            CalculatorLogic c1 = new CalculatorLogic();
            double expectedResult = 5;
            double actualResult = c1.SimpleDivision(20, 4);
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void TestRemainder()
        {
            CalculatorLogic c1 = new CalculatorLogic();
            double expectedResult = 2;
            double actualResult = c1.SimpleRemainder(17, 5);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
