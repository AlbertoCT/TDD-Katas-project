using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class PrimeFactor
    {
        public static List<int> Generate(int number)
        {
            List<int> primes = new List<int>();

            for (int candidate = 2; number > 1; candidate++)
            {
                for (; number % candidate == 0; number = number / candidate)
                {
                    primes.Add(candidate);
                }
            }

            return primes;
        }
    }
}
