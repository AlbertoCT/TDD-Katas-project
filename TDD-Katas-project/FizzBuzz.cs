using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Katas_project
{
    public class FizzBuzz
    {
        public string PrintNumber()
        {
            var number = new StringBuilder();

            for (var i = 1; i < 101; i++)
            {
                number.Append(IsFizzBuzz(i) ? $" FizzBuzz" : IsFizz(i) ? $" Fizz" : IsBuzz(i) ? $" Buzz" : $" {i}");
            }

            return number.ToString().Trim();
        }

        private bool IsFizz(int i)
        {
            return i % 3 == 0;
        }

        private bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }

        private bool IsFizzBuzz(int i)
        {
            return IsFizz(i) && IsBuzz(i);
        }
    }
}
