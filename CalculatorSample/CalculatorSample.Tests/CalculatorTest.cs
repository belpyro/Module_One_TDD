using CalculatorSample.Logic;
using Moq;
using NUnit.Framework;
using System.Diagnostics;

namespace CalculatorSample.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        private Mock<ILogger> mock;
        private Calculator calc;

        [SetUp]
        public void SetupTest()
        {
            mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            calc = new Calculator(mock.Object);
        }

        [TearDown]
        public void TearDown()
        {
            mock.Verify(l => l.Log(It.IsAny<string>()), Times.Exactly(1));
            mock = null;
            calc = null;
        }

        [Test]
        public void Test_Sum_Positive_Numbers()
        {
            var actual = calc.Add(3, 4);
            mock.Verify(l => l.Log(It.IsAny<string>()), Times.Exactly(1));
            Assert.AreEqual(expected: 7, actual: actual);
        }

        [Test]
        public void Test_Sum_Negative_Numbers()
        {
            var actual = calc.Add(-5, -8);
            Assert.AreEqual(expected: -13, actual: actual);
        }


        [TestCase(3,4,-1)]
        [TestCase(5,4,1)]
        [TestCase(-9,-3,-6)]
        public void Calculator_Subtract_ReturnCorrectResult(int x,int y,int expected)
        {
            var actual = calc.Subtract(x, y);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(1, 4, 0.25d)]
        [TestCase(10, 2, 5)]
        [TestCase(-9, -3, 3)]
        public void Calculator_Divide_ReturnCorrectResult(double x, double y, double expected)
        {
            var actual = calc.Divide(x, y);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculator_Divide_CatchDivideByZeroException()
        {
            Assert.Catch<System.DivideByZeroException>(()=>calc.Divide(-4,0));
        }

        [TestCase(4.5, 4.5, 20.25d)]
        [TestCase(10, 2, 20)]
        [TestCase(-3, 3, -9)]
        public void Calculator_Multiply_ReturnCorrectResult(double x, double y, double expected)
        {
            var actual = calc.Multiply(x, y);
            Assert.That(actual, Is.EqualTo(expected));
        }


        [TestCase(3, 2, 9)]
        [TestCase(5, 3, 125)]
        [TestCase(-7, 7, -823543)]
        public void Calculator_Exponentiation_ReturnCorrectResult(double x, double y, double expected)
        {
            var actual = calc.Exponentiation(x, y);
            Assert.AreEqual(expected: expected, actual: actual);
        }
    }
}
