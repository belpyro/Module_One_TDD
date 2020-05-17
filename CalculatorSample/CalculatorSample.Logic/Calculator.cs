using System;
using System.IO;

namespace CalculatorSample.Logic
{
    public class Calculator
    {
        private ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Операция сложения
        /// </summary>
        /// <param name="x">Принимает дробное число</param>
        /// <param name="y">Принимает дробное число</param>
        /// <returns>Возвращает результат: x + y</returns>
        public double Add(double x, double y)
        {
            _logger.Log($"Operation Sum: x={x}, y={y}");
            return x + y;
        }

        /// <summary>
        /// Операция вычитания
        /// </summary>
        /// <param name="x">Принимает дробное число</param>
        /// <param name="y">Принимает дробное число</param>
        /// <returns>Возвращает результат: x - y</returns>
        public int Subtract(int x, int y)
        {
            _logger.Log($"Operation Subtract: x={x}, y={y}");
            return x - y;
        }


        /// <summary>
        /// Операция деления
        /// </summary>
        /// <param name="x">Принимает дробное число</param>
        /// <param name="y">Принимает дробное число</param>
        /// <returns>Возвращает результат: x / y</returns>
        public double Divide(double x, double y)
        {
            _logger.Log($"Operation Divide: x={x}, y={y}");
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }

        /// <summary>
        /// Операция умножения
        /// </summary>
        /// <param name="x">Принимает дробное число</param>
        /// <param name="y">Принимает дробное число</param>
        /// <returns>Возвращает результат: x / y</returns>
        public double Multiply(double x, double y)
        {
            _logger.Log($"Operation Multiply: x={x}, y={y}");
            return x * y;
        }


        /// <summary>
        /// Операция возведение в степень
        /// </summary>
        /// <param name="x">Принимает дробное число</param>
        /// <param name="y">Принимает дробное число</param>
        /// <returns>Возвращает результат: x^y</returns>
        public double Exponentiation(double x, double y)
        {
            _logger.Log($"Operation Exponentiation: x={x}, y={y}");
            return Math.Pow(x,y);
        }

    }

    public class Logger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("log.txt", message);
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }
}
