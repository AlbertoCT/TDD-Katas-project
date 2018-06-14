using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenKata
{
    public class OddEven
    {
        public string PrintNumbers(int startNumber = 1, int finishNumber = 100)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = startNumber; i < finishNumber + 1; i++)
            {
                if (IsEven(i))
                {
                    stringBuilder.Append("Even,");
                }
                else if (IsPrime(i))
                {
                    stringBuilder.Append("Prime,");
                }
                else if (IsOdd(i))
                {
                    stringBuilder.Append("Odd,");
                }
                else
                {
                    stringBuilder.Append($"{i},");
                }
            }
            return stringBuilder.ToString().TrimEnd(new char[] { ',' });
        }

        public bool IsEven(int number)
        {
            bool IsEven = false;

            if (number % 2 == 0)
            {
                IsEven = true;
            }

            return IsEven;
        }

        public bool IsOdd(int number)
        {
            bool IsOdd = false;

            if (number % 2 != 0)
            {
                IsOdd = true;
            }

            return IsOdd;
        }

        public bool IsPrime(int number)
        {
            bool IsPrime = false;

            if (IsOdd(number))
            {
                IsPrime = true;

                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
            }

            return IsPrime;
        }
    }
}
