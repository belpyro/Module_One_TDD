using System;
using CalculatorSample.Logic;
using NUnit.Framework;
using Moq;
using System.Diagnostics;

namespace CalculatorSample.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Calculator_Test_Plus_PositiveNum()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(_ => _.Log(It.IsAny<string>())).Callback<string>(_ =>
            Debug.WriteLine(_));
            var calc = new Calculator(mock.Object);
            var actual = calc.Plus(3, 4);
            Assert.AreEqual(expected: 7, actual);
            mock.Verify(_ => _.Log(It.IsAny<string>()), Times.Exactly(1) );
        }

        [Test]
        public void Calculator_Test_Plus_NegativeNum()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(_ => _.Log(It.IsAny<string>())).Callback<string>(_ =>
            Debug.WriteLine(_));
            var calc = new Calculator(mock.Object);
            var actual = calc.Plus(-3,-84);
            Assert.AreEqual(expected: -87, actual);
            mock.Verify(_ => _.Log(It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Minus_PositiveNum()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(_ => _.Log(It.IsAny<string>())).Callback<string>(_ =>
            Debug.WriteLine(_));
            var calc = new Calculator(mock.Object);
            var actual = calc.Minus(9, 5);
            Assert.AreEqual(expected: 4, actual);
            mock.Verify(_ => _.Log(It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Minus_NegativeNum()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(_ => _.Log(It.IsAny<string>())).Callback<string>(_ =>
            Debug.WriteLine(_));
            var calc = new Calculator(mock.Object);
            var actual = calc.Minus(-3, -87);
            Assert.AreEqual(expected: 84, actual);
            mock.Verify(_ => _.Log(It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Multiply_PositiveNum()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(_ => _.Log(It.IsAny<string>())).Callback<string>(_ =>
            Debug.WriteLine(_));
            var calc = new Calculator(mock.Object);
            var actual = calc.Multiply(3, 4);
            Assert.AreEqual(expected: 12, actual);
            mock.Verify(_ => _.Log(It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Multiply_NegativeNum()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(_ => _.Log(It.IsAny<string>())).Callback<string>(_ =>
            Debug.WriteLine(_));
            var calc = new Calculator(mock.Object);
            var actual = calc.Multiply(-3, 4);
            Assert.AreEqual(expected: -12, actual);
            mock.Verify(_ => _.Log(It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Divide_PositiveNum()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(_ => _.Log(It.IsAny<string>())).Callback<string>(_ =>
            Debug.WriteLine(_));
            var calc = new Calculator(mock.Object);
            var actual = calc.Divide(2, 4);
            Assert.AreEqual(expected: 0.50, actual);
            mock.Verify(_ => _.Log(It.IsAny<string>()), Times.Exactly(1));
        }
        [Test]
        public void Calculator_Test_Divide_NegativeNum()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(_ => _.Log(It.IsAny<string>())).Callback<string>(_ =>
            Debug.WriteLine(_));
            var calc = new Calculator(mock.Object);
            var actual = calc.Divide(-1, 3);
            Assert.AreEqual(expected: -0.33, actual);
            mock.Verify(_ => _.Log(It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Degree_PositiveNum_PositiveDegree()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(_ => _.Log(It.IsAny<string>())).Callback<string>(_ =>
            Debug.WriteLine(_));
            var calc = new Calculator(mock.Object);
            var actual = calc.Degree(3, 3);
            Assert.AreEqual(expected: 27.00, actual);
            mock.Verify(_ => _.Log(It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Degree_PositiveNum_NegativeDegree()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(_ => _.Log(It.IsAny<string>())).Callback<string>(_ =>
            Debug.WriteLine(_));
            var calc = new Calculator(mock.Object);
            var actual = calc.Degree(3, -3);
            Assert.AreEqual(expected: 0.037, actual);
            mock.Verify(_ => _.Log(It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Degree_NegativeNum_PositiveDegree()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(_ => _.Log(It.IsAny<string>())).Callback<string>(_ =>
            Debug.WriteLine(_));
            var calc = new Calculator(mock.Object);
            var actual = calc.Degree(-3, 3);
            Assert.AreEqual(expected: -27.00, actual);
            mock.Verify(_ => _.Log(It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Degree_NegativeNum_NegativeDegree()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(_ => _.Log(It.IsAny<string>())).Callback<string>(_ =>
            Debug.WriteLine(_));
            var calc = new Calculator(mock.Object);
            var actual = calc.Degree(-3, -3);
            Assert.AreEqual(expected: -0.037, actual);
            mock.Verify(_ => _.Log(It.IsAny<string>()), Times.Exactly(1));
        }
    }
}
