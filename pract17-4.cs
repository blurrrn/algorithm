using System;
class pract
{
    class Money
    {
        int fisrt; // номинал
        int second; // кол-во
        public int Fisrt
        {
            set
            {
                if (value == 1 || value == 2 || value == 5 || value == 10 || value == 50 || value == 100 || value == 200 || value == 500 || value == 1000 || value == 2000 || value == 5000)
                { fisrt = value; }
                else
                {
                    Console.WriteLine($"Не существует купюры/монеты {value} рублей");
                }
            }
            get { return fisrt; }
        }
        public int Second
        {
            set
            {
                if (value >= 0) { second = value; }
                else
                {
                    Console.WriteLine("Количество не может быть меньше нуля");
                }
            }
            get { return second; }
        }
        public int Summa
        {
            get { return this.Fisrt * this.Second; }
        }
        public Money(int fisrt, int second)
        {
            this.Second = second;
            this.Fisrt = fisrt;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Номинал = {this.Fisrt}");
            Console.WriteLine($"Количество = {this.Second}\n");
        }
        public bool CanBuy(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Сумма не может быть меньше или равна нулю");
            }
            if (n <= this.Summa) { return true; }
            return false;
        }
        public int CanBuyCount(int n)
        {
            if (CanBuy(n)) { return this.Summa / n; }
            else { return 0; }
        }
        public int this[int index]
        {
            get
            {
                if (index == 0) { return this.Fisrt; }
                else if (index == 1) { return this.Second; }
                else
                {
                    Console.WriteLine("Неверный индекс");
                    return -1;
                }
            }
            set
            {
                if (index == 0) { this.Fisrt = value; }
                else if (index == 1) { this.Second = value; }
                else
                {
                    Console.WriteLine("Неверный индекс");
                }
            }

        }
        public static Money operator ++(Money cash)
        {
            cash.Fisrt++;
            cash.Second++;
            return cash;
        }
        public static Money operator +(Money cash, int number)
        {
            cash.Second += number;
            return cash;
        }
        public static bool operator !(Money cash)
        {
            return cash.Second != 0;
        }
        public static Money operator --(Money cash)
        {
            cash.Fisrt--;
            cash.Second--;
            return cash;
        }
    }
    public static void Main()
    {
        Money money1 = new Money(1, 10);
        Console.WriteLine("Экземпляр первый:");
        money1.PrintInfo();
        money1++;
        Console.WriteLine("Увеличили первый, задаём второй экземпляр:");
        Money money2 = new Money(100, 2);
        money1.PrintInfo();
        money2.PrintInfo();
        Console.WriteLine("Проверка после убавления второго экземпляра:");
        money2--;
        money2.PrintInfo();
        Console.WriteLine("Прибавляем количество денег +10 ко второму экземпляру:");
        money2 += 10;
        money2.PrintInfo();
        Console.WriteLine("Сумма второго экземпляра:");
        Console.WriteLine(money2.Summa);
        int n = 177;
        Console.WriteLine($"Проверяем сколько товаров по {n}р можно купить:");
        Console.WriteLine(money2.CanBuyCount(n));
        Console.WriteLine("Понижаем номинал:");
        money2.Fisrt = 1;
        money2.PrintInfo();
        Console.WriteLine("Проверка можем ли купить вообще:");
        Console.WriteLine(money2.CanBuy(n));
        Console.WriteLine("Повышаем номинал:");
        money2.Fisrt = 200;
        money2.PrintInfo();
        Console.WriteLine("Проверка можем ли купить вообще:");
        Console.WriteLine(money2.CanBuy(n));
        Console.WriteLine("Ставим кол-во купюр 0:");
        money2.Second = 0;
        money2.PrintInfo();
        Console.WriteLine("Проверка на !0:");
        Console.WriteLine(!money2);
        Console.WriteLine("Ставим кол-во купюр 3:");
        money2.Second = 3;
        money2.PrintInfo();
        Console.WriteLine("Проверка на !0:");
        Console.WriteLine(!money2);
        Console.WriteLine($"money2[0] = {money2[0]}, money2[1] = {money2[1]}\nmoney1[0] = {money1[0]}, money1[1] = {money1[1]}");
    }
}
