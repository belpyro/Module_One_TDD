using CalculatorSample.Logic;
using Moq;
using NUnit.Framework;
using System.Diagnostics;

namespace CalculatorSample.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Test_Sum_Positive_Numbers()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));

            var calc = new Calculator(mock.Object);
            var actual = calc.Add(3, 4);
            mock.Verify(l => l.Log(It.IsAny<string>()), Times.Exactly(1));
            Assert.AreEqual(expected: 7, actual);
        }

        [Test]
        public void Test_Sum_Negative_Numbers()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));

            var calc = new Calculator(mock.Object);
            var actual = calc.Add(-5, -8);
            Assert.AreEqual(expected: -13, actual);
        }
    }
}
