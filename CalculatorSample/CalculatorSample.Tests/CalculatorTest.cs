using System;
using CalculatorSample.Logic;
using NUnit.Framework;
using Moq;
using System.Diagnostics;
using System.Linq.Expressions;

namespace CalculatorSample.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        Expression< Action<ILogger> > verifyExpression =  _ => _.Log(It.IsAny<string>());

        private Mock<ILogger> MockInitiliser()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(verifyExpression).Callback<string>(_ => Debug.WriteLine(_));
            return mock;
        }

        [Test]
        public void Calculator_Test_Plus_PositiveNum()
        {
            var mock = MockInitiliser();            
            Assert.AreEqual(expected: 7, (new Calculator(mock.Object)).Plus(3, 4));
            mock.Verify(verifyExpression, Times.Exactly(1) );
        }

        [Test]
        public void Calculator_Test_Plus_NegativeNum()
        {
            var mock = MockInitiliser();
            Assert.AreEqual(expected: -87, (new Calculator(mock.Object)).Plus(-3, -84));
            mock.Verify(verifyExpression, Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Minus_PositiveNum()
        {
            var mock = MockInitiliser();
            Assert.AreEqual(expected: 4, (new Calculator(mock.Object)).Minus(9, 5));
            mock.Verify(verifyExpression, Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Minus_NegativeNum()
        {
            var mock = MockInitiliser();
            Assert.AreEqual(expected: 84, (new Calculator(mock.Object)).Minus(-3, -87));
            mock.Verify(verifyExpression, Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Multiply_PositiveNum()
        {
            var mock = MockInitiliser();
            Assert.AreEqual(expected: 12, (new Calculator(mock.Object)).Multiply(3, 4));
            mock.Verify(verifyExpression, Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Multiply_NegativeNum()
        {
            var mock = MockInitiliser();
            Assert.AreEqual(expected: -12, (new Calculator(mock.Object)).Multiply(-3, 4));
            mock.Verify(verifyExpression, Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Divide_PositiveNum()
        {
            var mock = MockInitiliser();
            Assert.AreEqual(expected: 0.50, (new Calculator(mock.Object)).Divide(2, 4));
            mock.Verify(verifyExpression, Times.Exactly(1));
        }
        [Test]
        public void Calculator_Test_Divide_NegativeNum()
        {
            var mock = MockInitiliser();
            Assert.AreEqual(expected: -0.33, (new Calculator(mock.Object)).Divide(-1, 3));
            mock.Verify(verifyExpression, Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Degree_PositiveNum_PositiveDegree()
        {
            var mock = MockInitiliser();
            Assert.AreEqual(expected: 27.00, (new Calculator(mock.Object)).Degree(3, 3));
            mock.Verify(verifyExpression, Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Degree_PositiveNum_NegativeDegree()
        {
            var mock = MockInitiliser();
            Assert.AreEqual(expected: 0.037, (new Calculator(mock.Object)).Degree(3, -3));
            mock.Verify(verifyExpression, Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Degree_NegativeNum_PositiveDegree()
        {
            var mock = MockInitiliser();
            Assert.AreEqual(expected: -27.00, (new Calculator(mock.Object)).Degree(-3, 3));
            mock.Verify(verifyExpression, Times.Exactly(1));
        }

        [Test]
        public void Calculator_Test_Degree_NegativeNum_NegativeDegree()
        {
            var mock = MockInitiliser();
            Assert.AreEqual(expected: -0.037, (new Calculator(mock.Object)).Degree(-3, -3));
            mock.Verify(verifyExpression, Times.Exactly(1));
        }
    }
}
