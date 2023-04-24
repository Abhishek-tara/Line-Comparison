namespace LineComparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Camparison Problem");
            CalculateLine obj = new CalculateLine(2, 3, 4, 5);
            double length_One =  obj.Calculate();

            CalculateLine obj_Two = new CalculateLine(4, 8, 6, 9);
            double length_Two = obj_Two.Calculate();

            if (length_One.Equals(length_Two))           
                Console.WriteLine("Both lines are equal");         
            else
                Console.WriteLine("Not equal");
        }
    }
}
