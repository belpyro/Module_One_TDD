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
