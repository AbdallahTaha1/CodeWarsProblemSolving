using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsProblemSolving
{
    internal static class Kata6Problems
    {
        #region 1# Tower Builder
        public static string[] TowerBuilder(int nFloors)
        {
            string[] strings = new string[nFloors];
            for (int i = 0; i < nFloors; i++)
            {
                StringBuilder str = new StringBuilder();
                for (int k = nFloors-i-1; k > 0; k--) str.Append(" ");
                for (int k = i * 2 + 1; k > 0; k--) str.Append("*");
                for (int k = nFloors - i - 1; k > 0; k--) str.Append(" ");
                strings[i] = str.ToString();
            }
            return strings;
        }
        #endregion
    }
}
