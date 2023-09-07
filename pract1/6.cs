public class Program
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("a = {0:.##}", a);
        Console.WriteLine("b = {0:.##}", b);
        Console.WriteLine("b = {0:.##}", c);
        Console.WriteLine("({0:.##} + {1:.##}) + {2:.##} = {0:.##} + ({1:.##} + {2:.##})", a, b, c);
    }
}
