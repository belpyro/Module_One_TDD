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

        public int Sum(int x, int y)
        {
            _logger.Log($"Operation Sum: x = {x}, y = {y}");
            return x + y;
        }

        public double Exponentiations(double x, double y)
        {
            _logger.Log($"Operation Sum: x = {x}, y = {y}");
            return Math.Pow(x, y);
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
