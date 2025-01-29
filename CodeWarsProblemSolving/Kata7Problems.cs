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
            foreach (var x in n.ToString())
            {
                int digit = int.Parse(x.ToString());
                result.Append(digit * digit);
            }
            return int.Parse(result.ToString());
        }
        #endregion

        #region 2# Growth of a Population
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int nbYears = 0;
            double currentP = p0;
            while(currentP < p)
            {
                currentP = Math.Floor(currentP * (1 + percent / 100) + aug);
                nbYears++;
            }
            return nbYears;
        }
        #endregion

        #region 3# Get the Middle Character
        public static string GetMiddle(string s)
        {
            if (s.Length % 2 != 0)
            {
                return $"{s[s.Length / 2]}";
            }
            else
            {
                return $"{s[s.Length / 2 - 1]}{s[s.Length / 2]}";
            }
        }
        #endregion

        #region 4# Sum of the first nth term of Series
        public static string seriesSum(int n)
        {
            if (n == 0) return "0.00";
            double result = 0.0d;
            
            for (int i = 1; i <= n; i++)
                result += 1.0 / (1 + (i - 1) * 3);
            
            return result.ToString("F2");
        }
        #endregion

        #region 5# Reverse words
        public static string ReverseWords(string str) 
            => String.Join(" ", str.Split(" ").Select(s => new String(s.Reverse().ToArray())));
        #endregion

    }
}
