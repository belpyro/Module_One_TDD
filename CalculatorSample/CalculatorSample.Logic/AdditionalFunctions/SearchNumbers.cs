using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSample.Logic.AdditionalFunctions
{
    public class SearchNumbers
    {
        List<double> allNumbersRange;
        public SearchNumbers()
        {
            allNumbersRange = new List<double>();
        }
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
    }
}
