namespace CodeWarsProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = Kata7Problems.NbYear(1500000, 2.5, 10000, 2000000);
            Console.WriteLine(Convert.ToInt32(output));
        }
    }
}
