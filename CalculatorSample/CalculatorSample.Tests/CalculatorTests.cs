using System.Diagnostics;
using CalculatorSample.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace CalculatorSample.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));

            // arrange
            int x = 10;
            int y = 20;
            int expected = 30;

            //act
            Calculator calc = new Calculator(mock.Object);
            int actual = calc.Sum(x, y);
            mock.Verify(l => l.Log(It.IsAny<string>()), Times.Exactly(1));

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Exponentiations_2_4_16returned()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));

            // arrange
            double x = 2;
            double y = 4;
            double expected = 16;

            //act
            Calculator calc = new Calculator(mock.Object);
            double actual = calc.Exponentiations(x, y);
            mock.Verify(l => l.Log(It.IsAny<string>()), Times.Exactly(1));

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
