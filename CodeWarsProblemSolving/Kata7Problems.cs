using System;
using System.Text;

namespace CodeWarsProblemSolving
{
    internal class Kata7Problems
    {
        #region 1# Square Every Digit
        public static int SquareDigits(int n)
        {
            StringBuilder result = new StringBuilder();
            var chars = n.ToString();
            foreach (var x in chars)
            {
                int digit = int.Parse(x.ToString());
                result.Append(digit * digit);
            }
            return int.Parse(result.ToString());
        }
        #endregion


    }
}
