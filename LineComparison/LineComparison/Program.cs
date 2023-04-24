namespace LineComparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Camparison Problem");
            CalculateLine obj = new CalculateLine(2, 3, 4, 5);
            double length_One =  obj.Calculate();

            CalculateLine obj_Two = new CalculateLine(2, 3, 4, 5);
            double length_Two = obj_Two.Calculate();

            if (length_One.Equals(length_Two))           
                Console.WriteLine("Both lines are equal");         
            else
                Console.WriteLine("Not equal");

            if (length_One.CompareTo(length_Two) == 0)
                Console.WriteLine("Both lines are equal");
            else if (length_One.CompareTo(length_Two) > 0)
                Console.WriteLine("Line one is greater than line two");
            else
                Console.WriteLine("Line Two is greater than line one");
        }
    }
}
