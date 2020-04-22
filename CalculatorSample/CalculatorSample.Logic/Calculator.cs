using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSample.Logic
{
    public class Calculator
    {
        ILogger _logger;
        public Calculator(ILogger logger)
        {
            _logger = logger;
        }
        public int Plus(int x, int y)
        {
            _logger.Log($"Operation {x} + {y}");
            return x + y;
        }

        public int Minus (int x, int y)
        {
            _logger.Log($"Operation {x} - {y}");
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            _logger.Log($"Operation {x} * {y}");
            return x * y;
        }

        public double Divide(int x, int y)
        {
            _logger.Log($"Operation {x} / {y}");
            return Math.Round((double)x / (double)y, 2);
        }

        public int[] SearchNumber(int number, int power )
        {
            List<int> allNumberList = new List<int>();
            if (number < 0 || power < 0)
                throw new ArgumentNullException("Arguments should be more than 0!!!");
            else
            {
                int minNum = (int)Math.Pow(10, power - 1);
                int maxNum = (int)Math.Pow(10, power) - 1;
               
                for (int i = minNum; i < maxNum; i++)
                {
                    if (i.ToString().Select(_ => int.Parse(_.ToString())).Sum() == number)
                        allNumberList.Add(i);
                }
                _logger.Log($"Operation searching {number} in {power}");              
            }
            return allNumberList.Count != 0 ? new[] { allNumberList.Count, allNumberList.Min(), allNumberList.Max() } : new int[] { };

        }

        public double Degree(int x, int y)
        {
            _logger.Log($"Operation {x} ^ {y}");
            return Math.Round(Math.Pow(x,y),3);
        }
    }
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("logger.txt", message);
        }
    }
    public interface ILogger
    {
       void Log(string message);
    }
}
