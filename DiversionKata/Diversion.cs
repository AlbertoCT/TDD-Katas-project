using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DiversionKata
{
    public class Diversion
    {
        public static int BinaryNumbersSize(int digit)
        {
            var binarys = BinaryNumbersGenerator(digit);
            var nonAdjacent1s = new List<string>();

            foreach (var binary in binarys)
            {
                if (!Regex.IsMatch(binary, @"11"))
                {
                    nonAdjacent1s.Add(binary);
                }
            }

            return nonAdjacent1s.Count;
        }

        private static List<string> BinaryNumbersGenerator(int digit)
        {
            List<string> binarys = new List<string>();
            int i = 0;
            string binary = string.Empty;
            var maxValue = string.Empty.PadLeft(digit, '1');

            while (binary != maxValue)
            {
                binary = Convert.ToString(i, 2).PadLeft(digit, '0');
                binarys.Add(binary);
                i++;
            }

            return binarys;
        }
    }
}
