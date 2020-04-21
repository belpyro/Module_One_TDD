using CalculatorSample.Logidc.Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CalculatorSample.Logic
{
    public class Calculator
    {
        private ILogger _logger;
        List<double> allNumbersRange;
        public Calculator()
        {
            allNumbersRange = new List<double>();
        }

        public Calculator(ILogger logger)
        {
            _logger = logger;

        }
        #region Methods
        public int Addition(int x, int y)
        {
            _logger.Log($"Operation Addition: x={x}, y={y}");
            return x + y;
        }
        public int Subtraction(int x, int y)
        {
            _logger.Log($"Operation Subtraction: x={x}, y={y}");
            return x - y;
        }
        public int Multiplication(int x, int y)
        {
            _logger.Log($"Operation Multiplication: x={x}, y={y}");
            return x * y;
        }
        public int Division(int x, int y)
        {
            _logger.Log($"Operation Division: x={x}, y={y}");
            return x / y;
        }
        public double Pow(double x, double y)
        {
            _logger.Log($"Operation Exponentiation: x={x}, y={y}");
            return Math.Pow(x, y);

        }
        #endregion

        #region Method Lesson-3

        public int[] GetArray_Numbers(double bit, double summNumb)
        {

                if (!(bit < 0 || summNumb < 0))
                {
                    double maxNumber = Math.Pow(10, bit);
                    double minNumber = Math.Pow(10, bit - 1) - 1;

                    for (int i = (int)minNumber + 1; i < maxNumber && i > minNumber; i++)
                    {
                        int summ = SummNumbers(i);
                        if (summ == summNumb)
                        {
                            allNumbersRange.Add(i);
                        }
                    }
                    int[] result = new int[3];
                    if (allNumbersRange.Count != 0)
                    {
                        result[0] = allNumbersRange.Count;
                        result[1] = (int)allNumbersRange.Min();
                        result[2] = (int)allNumbersRange.Max();
                        return result;
                    }
                    return result;
                }
                else
                {
                    throw new Exception("В метод переданы отрицательные числа!");
                }

        }
        int SummNumbers(int number)
        {
            int s = 0;
            while (number > 0)
            {
                s = s + number % 10;
                number = number / 10;
            }
            return s;
        }
        #endregion
    }
}
