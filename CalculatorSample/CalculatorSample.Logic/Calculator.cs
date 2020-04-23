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
            _logger.Log($"Operation Exponentiations: x = {x}, y = {y}");
            return Math.Pow(x, y);
        }

        public double SumArrayitemsRaisedToPower(double[] items, double bitNamber)
        {
            double sum = 0;
            for (int i = 0; i < items.Length; i++)
            {
                sum += items[i];

            }
            _logger.Log($"Operation SumArrayitemsRaisedToPower: double[] items = {items}, " +
                $"double bitNamber = {bitNamber} ");
            return Math.Pow(sum, bitNamber);
        }

        public int GetMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            _logger.Log($"Operation GetMax: int[] array = {array}");
            return max;
        }

        public decimal CalcDeposit(decimal sum, decimal percent = 10m, decimal bonus = 0m)
        {
            _logger.Log($"Operation CalcDeposit: decimal sum = {sum}, decimal percent = {percent}, " +
                $"decimal bonus = {bonus}");
            return sum + sum * ((percent + bonus) / 100m);
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
