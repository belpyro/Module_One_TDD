using CalculatorSample.Logic;
using CalculatorSample.Logidc.Logger;
using Moq;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace CalculatorSample.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        public Mock<ILogger> CreateMock()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            return mock;
        }
        public void Verify(Mock<ILogger> obj, double expectedReuslt, double realResult)
        {
            obj.Verify(l => l.Log(It.IsAny<string>()), Times.Exactly(1));
            Assert.AreEqual(expected: expectedReuslt, realResult);
        }
        #region Сложение
        [Test]
        public void Test_Sum_Positive_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Addition(3, 4);
            Verify(mock, 7,  calc);
        }

        [Test]
        public void Test_Sum_Negative_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Addition(-3, -4);
            Verify(mock, -7, calc);
        }
        [Test]
        public void Test_Sum_Negative_and_Positive_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Addition(3, -4);
            Verify(mock, -1, calc);
        }
        [Test]
        public void Test_Sum_Number_and_Zero_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Addition(3, 0);
            Verify(mock, 3, calc);
        }

        #endregion
        #region Вычитание
        [Test]
        public void Test_Substr_Positive_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Subtraction(15, 5);
            Verify(mock, 10, calc);
        }
        [Test]
        public void Test_Substr_Negative_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Subtraction(-15, -5);
            Verify(mock, -10, calc);
        }
        [Test]
        public void Test_Substr_Negative_and_Positive_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Subtraction(15, -5);
            Verify(mock, 20, calc);
        }
        [Test]
        public void Test_Substr_Nunber_and_Zero_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Subtraction(-5, 0);
            Verify(mock, -5, calc);
        }
        #endregion
        #region Умножение
        [Test]
        public void Test_Multi_Positive_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Multiplication(3, 4);
            Verify(mock, 12, calc);
        }
        [Test]
        public void Test_Multi_Negative_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Multiplication(-2, -3);
            Verify(mock, 6, calc);
        }
        [Test]
        public void Test_Multi_Negative_and_Positive_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Multiplication(-2, 3);
            Verify(mock, -6, calc);
        }
        [Test]
        public void Test_Multi_Number_by_Zero_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Multiplication(13, 0);
            Verify(mock, 0, calc);
        }
        [Test]
        public void Test_Multi_Zero_by_Number_()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Multiplication(0, -12);
            Verify(mock, 0, calc);
        }
        #endregion
        #region Деление
        [Test]
        public void Test_Division_Positive_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Division(15, 5);
            Verify(mock, 3, calc);
        }
        [Test]
        public void Test_Division_Negative_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Division(-20, -5);
            Verify(mock, 4, calc);
        }
        [Test]
        public void Test_Division_Negative_by_Positive_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Division(-20, 5);
            Verify(mock, -4, calc);
        }
        [Test]
        public void Test_Division_Positive_by_Negativ_Numbers()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Division(20, -5);
            Verify(mock, -4, calc);
        }
        [Test]
        public void Test_Division_Number_by_Zero()
        {
            var exceptionThrown = false;
            var mock = CreateMock();
            try
            {
                var calc = new Calculator(mock.Object).Division(6, 0);
            }
            catch (DivideByZeroException)
            {
                exceptionThrown = true;
            }
            Assert.IsTrue(exceptionThrown);
        }
        [Test]
        public void Test_Division_Zero_by_Number()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Division(0, 3);
            Verify(mock, 0, calc);
        }
        #endregion
        #region Возведение в степень
        [Test]
        public void Test_Pow_Positive_Numbers_Positive_Pow()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Pow(2, 2);
            Verify(mock, 4, (int)calc);
        }
        [Test]
        public void Test_Pow_Negative_Number_Positive_Pow()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Pow(2, -2);
            Verify(mock, 0.25, calc);
        }
        [Test]
        public void Test_Pow_Positive_Number_Negative_Pow()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Pow(10, -2);
            Verify(mock, 0.01, calc);
        }
        [Test]
        public void Test_Pow_Negative_Number_Negative_Pow()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Pow(-100, -2);
            Verify(mock, 0.0001, calc);
        }
        [Test]
        public void Test_Pow_Zero_Pow()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Pow(100, 0);
            Verify(mock, 1, calc);
        }
        [Test]
        public void Test_Pow_Number_Zero()
        {
            var mock = CreateMock();
            var calc = new Calculator(mock.Object).Pow(0, 3);
            Verify(mock, 0, calc);
        }
        #endregion
    }
}
