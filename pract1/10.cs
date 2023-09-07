public class Program
{
    public static void Main()
    {
        Console.WriteLine("Как тебя зовут?");
        string s = Console.ReadLine();
        Console.WriteLine("Сколько тебе лет?");
        int x = int.Parse(Console.ReadLine());
        int y = 2009 - x;
        Console.WriteLine("{0}, ты родился(ась) в {1} году.", s, y);
    }
}
