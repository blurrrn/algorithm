/*5. Разработать метод, который для заданного натурального числа N возвращает сумму его
нечетных цифр. С помощью данного метода:
a) для каждого целого числа на отрезке [a, b] вывести на экран сумму его нечетных цифр;
b) вывести на экран только те целые числа отрезка [a, b], у которых сумма нечетных цифр числа
равна заданному значению С;
c) вывести на экран только те целые числа отрезка [a, b], у которых сумма нечетных цифр является
простым числом;
d) для заданного числа А вывести на экран ближайшее следующее по отношению к нему число,
сумма нечетных цифр которого равна сумме нечетных цифр числа А.
*/
class Program
{
    static int sum_n(int n)
    {
        int sum = 0, t;
        while (n > 0)
        {
            t = (n % 10) % 2 != 0 ? n % 10 : 0;
            sum += t;
            n /= 10;
        }
        return sum;
    }
    static bool is_prime(int n)
    {
        int d = 2;
        if (n <= 3 && n != 0)
            return true;
        if (n == 0) return false;
        while (d * d <= n)
        {
            if (n % d == 0)
            {
                return false;
            }
            d++;
        }
        return true;
    }
    static void A(int a, int b)
    {
        for (int x = a; x <= b; x++)
        {
            Console.Write($"Сумма нечёт. цифр числа {x} = {sum_n(x)}\n");
        }
    }
    static void B(int a, int b)
    {
        Console.Write("Введите число С: ");
        int C = Convert.ToInt32(Console.ReadLine());
        for (int x = a; x <= b; x++)
            Console.Write(sum_n(x) == C ? $"{x} " : "");
    }
    static void C(int a, int b)
    {
        for (int x = a; x <= b; x++)
            Console.Write(is_prime(sum_n(x)) ? $"{x} " : "");
    }
    static void D(int a, int b)
    {
        int t = sum_n(a);
        a++;
        while (true)
            {
                if (sum_n(a) == t)
                {
                    Console.Write(a);
                    break;
                }
                a++;
        }
    }
    static void Main()
    {
        int a, b;
        Console.Write("Введите a = ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите b = ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-" + "Задача А" + "-");
        A(a, b);
        Console.WriteLine("--------");

        Console.WriteLine("-" + "Задача B" + "-");
        B(a, b);
        Console.WriteLine("\n--------");

        Console.WriteLine("-" + "Задача C" + "-");
        C(a, b);
        Console.WriteLine("\n--------");

        Console.WriteLine("-" + "Задача D" + "-");
        D(a, b);
        Console.WriteLine("\n--------");
    }
}
