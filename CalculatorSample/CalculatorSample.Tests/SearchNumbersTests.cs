using CalculatorSample.Logic.AdditionalFunctions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSample.Tests
{
    public class SearchNumbersTest
    {
        public void Assert_Test_Search_Numbers(int a, int b, int c, double lenghtNumbers, double summNumbers)
        {
            int[] testArray = { a, b, c };
            var calc = new SearchNumbers();
            int[] realResult = calc.GetArray_Numbers(lenghtNumbers, summNumbers);
            Assert.AreEqual(testArray, realResult);
        }

        [Test]
        public void Test_Search_Numbers_Summ_Positive_Bit_Positive_Count_Above_Zero()
        {
            Assert_Test_Search_Numbers(3, 12, 30, 2, 3);
        }
        [Test]
        public void Test_Search_Numbers_Summ_Positive_Bit_Positive_Count_Zero()
        {
            Assert_Test_Search_Numbers(0, 0, 0, 2, 20);
        }
        [Test]
        public void Test_Search_Numbers_Negative_Arg()
        {
            var exceptionThrown = false;
            try
            {
                Assert_Test_Search_Numbers(0, 0, 0, 2, -7);
            }
            catch (Exception)
            {
                exceptionThrown = true;
            }
            Assert.IsTrue(exceptionThrown);

        }
        [Test]
        public void Test_Search_Numbers_Arg_Zero()
        {
            Assert_Test_Search_Numbers(0, 0, 0, 0, 0);
        }
    }
}
