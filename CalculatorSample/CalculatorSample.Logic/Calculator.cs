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

    }
}
