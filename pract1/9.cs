public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите сумму вклада:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите процент по вкладу:");
        double b = double.Parse(Console.ReadLine());
        double s = a / 100 * b + a;
        Console.WriteLine("Через год сумма на вкладе: {0:c}", s);
    }
}
