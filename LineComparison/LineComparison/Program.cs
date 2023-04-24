namespace LineComparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Camparison Problem");
            CalculateLine firstLine = new CalculateLine(2, 3, 4, 5);
            firstLine.Calculate();
        }
    }
}
