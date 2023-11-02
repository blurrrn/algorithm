using System;
class Program
{
    static void InputArray(out int[][] a, int n, out int min_elem)
    {
        min_elem = 1000000;
        a = new int[n+1][];
        for (int i = 0; i < n; i++) { a[i] = new int[n]; }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                a[i][j] = Convert.ToInt32((Console.ReadLine()));
                min_elem = Math.Min(min_elem, a[i][j]);
            }
        }
    }
    static void Print(int[][] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", a[i][j]);
            }
            Console.WriteLine();
        }
    }
    static void InputRaw(int[][] a, int pos, int n)
    {
        for (int i = n; i > pos; i--)
        {
            a[i] = a[i - 1];
        }
        a[pos + 1] = new int[n];
    }
    static void Main()
    {
        Console.Write($"Введите n = ");
        int min_elem;
        int n = Convert.ToInt32(Console.ReadLine());
        int k = n;
        int[][] a;
        int[] zeros = new int[n];
        Console.Write("Вводите массив по строчкам \n");
        InputArray(out a, n, out min_elem);
        Console.WriteLine("Массив:");
        Print(a, n);
        int idx = -1;
        bool flag = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i][j] == min_elem)
                {
                    idx = i;
                    flag = true;
                    break;
                }
            }
            if (flag) { break; }
        }
        //Console.WriteLine(idx);
        //Console.WriteLine(min_elem);
        if (idx != -1)
        {
            InputRaw(a, idx, n);
            n++;
        }
        else
        {
            Console.WriteLine("Ошибка, элемент не был найден в массиве");
        }
        Console.WriteLine("---------------------");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                Console.Write($"{a[i][j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("---------------------");
    }
}
