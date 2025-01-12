namespace CodeWarsProblemSolving
{
    static class Kata8Problems
    {
        #region 1# Abbreviate a Two Word Name
        // Link: https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3/train/csharp
        public static string AbbrevName(string name)
        {
            if (String.IsNullOrWhiteSpace(name)) return String.Empty;
            if (name.Length == 1) return String.Empty;
            var names = name.Split(' ');
            return $"{Char.ToUpper(names[0][0])}.{Char.ToUpper(names[1][0])}";
        }
        #endregion

        #region 2# Beginner - Lost Without a Map
        // Link: https://www.codewars.com/kata/57f781872e3d8ca2a000007e/train/csharp
        public static int[] Maps(int[] x) => x.Select(x => x * 2).ToArray();
        #endregion

        #region 3# Convert boolean values to strings 'Yes' or 'No'.
        public static string boolToWord(bool word) => word ? "Yes" : "No";
        #endregion

        #region 4# Counting sheep...
        public static int CountSheeps(bool[] sheeps) => sheeps.Count(x => x);
        #endregion

        #region 5# Opposites Attract
        public static bool lovefunc(int flower1, int flower2) =>
            (flower1 + flower2) % 2 != 0 ? true : false;
        #endregion

        #region 6# Sum without highest and lowest number
        public static int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2) return 0;
            Array.Sort(numbers);
            int sum = 0;
            for (int i = 1; i < numbers.Length - 1; i++)
                sum += numbers[i];
            return sum;
        }
        #endregion


    }
}
