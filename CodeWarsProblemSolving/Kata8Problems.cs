namespace CodeWarsProblemSolving
{
    static class Kata8Problems
    {
        #region #1 Abbreviate a Two Word Name
        // Link: https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3/train/csharp
        public static string AbbrevName(string name)
        {
            if (String.IsNullOrWhiteSpace(name)) return String.Empty;
            if (name.Length == 1) return String.Empty;
            var names = name.Split(' ');
            return $"{Char.ToUpper(names[0][0])}.{Char.ToUpper(names[1][0])}";
        }
        #endregion

        
    }
}
