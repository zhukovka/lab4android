using System;
using System.Linq;

namespace CountNumbersLib
{
    public class Count
    {
        public int CountWords(string input)
        {
            return input.Split().Length;
        }

        public int CountSpaces(string input)
        {
            return input.Count(Char.IsWhiteSpace);
        }

        public double CountSum(int a1, int an)
        {
          
            int n = an - a1 + 1;
            return (a1 + an) / 2.0 * n;
        }
    }
}
