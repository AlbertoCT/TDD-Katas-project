using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStats
{
    public class CalculationStats
    {
        public static int CalculateMinimum(List<int> numbers)
        {
            return (numbers == null || !numbers.Any()) ? 0 : numbers.OrderBy(x => x).First();
        }

        public static int CalculateMaximum(List<int> numbers)
        {
            return (numbers == null || !numbers.Any()) ? 0 : numbers.OrderByDescending(x => x).First();
        }

        public static int CalculateNumberOfElements(List<int> numbers)
        {
            return numbers == null ? 0 : numbers.Count;
        }

        public static double CalculateAverage(List<int> numbers)
        {            
            return (numbers == null || !numbers.Any()) ? 0 : numbers.Average();
        }
    }
}
