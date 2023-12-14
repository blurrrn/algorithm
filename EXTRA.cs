using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

class ExtraProblem
{
    public static void Pryamoy(ref StringBuilder orig, ref StringBuilder pattern, int n, int m, StreamWriter writer)
    {
        //алгоритм прямого поиска строки в подстроке
        List<int> list = new List<int>();

        Stopwatch sw = new Stopwatch();
        int count = 0; //число вхождений
        writer.WriteLine("\nАлгоритм прямого поиска строки в подстроке");
        sw.Restart();
        int index = -1;
        for (int i = 0; i <= n - m; i++)
        {
            int j;
            for (j = 0; j < m; j++)
            {
                if (orig[i + j] != pattern[j])
                    break;
            }
            if (j == m)
            { //все символы совпали
                index = i;
                count++;
                list.Add(index);
            }
        }
        sw.Stop();
        if (index == -1)
            writer.WriteLine("Подстрока не найдена");
        else
            writer.WriteLine("Всего вхождений: " + count);
        for (int i = 0; i < count - 1; i++)
        {
            index = list[i];
            writer.Write("Подстрока найдена в позиции: " + index + " ");
            for (int k = index; k < index + m + 1; k++)
                writer.Write(orig[k]);
            writer.Write("...\n");
        }
        writer.WriteLine("Время работы: " + sw.ElapsedTicks + " тактов");
    }

    public static void Karpa_Rabina(ref StringBuilder orig, ref StringBuilder pattern, int n, int m, StreamWriter writer)
    {

        //алгоритм Карпа-Рабина
        Stopwatch sw = new Stopwatch();
        List<int> list = new List<int>();
        writer.WriteLine("\nАлгоритм Карпа-Рабина");
        const long P = 67;
        long[] pwp = new long[n];
        pwp[0] = 1;

        for (int i = 1; i < n; i++)
        {
            pwp[i] = pwp[i - 1] * P;
        }
        int count = 0; //число вхождений
                       //вычисляем массив хеш-значений для всех префиксов исходной строки
        long[] h = new long[n];
        h[0] = (orig[0] - 'a' + 1) * pwp[0];
        for (int i = 1; i < n; i++)
        {
            h[i] = (orig[i] - 'a' + 1) * pwp[i];
            h[i] += h[i - 1];
        }
        //вычисляем хэш-значение для подстроки
        long h_s = 0;
        for (int i = 0; i < m; i++)
        {
            h_s += (pattern[i] - 'a' + 1) * pwp[i];
        }
        int temp = 0;
        sw.Restart();
        //проводим поиск по хеш-значениям
        for (int i = 0; i + m - 1 < n; i++)
        {
            //находим хэш-значение подстроки T начиная с позиции i длиною s.Length
            long cur_h = h[i + m - 1];
            if (i > 0)
            {
                cur_h -= h[i - 1];
            }
            //приводим хэш-значения двух подстрок к одной степени
            if (cur_h == h_s * pwp[i])
            { // если хеш-значения равны, то и подстроки равны
                temp = 1;
                count++;
                list.Add(i);
            }
        }
        sw.Stop();
        if (temp == 0)
            writer.WriteLine("Подстрока не найдена");
        else
        {
            writer.WriteLine("Всего вхождений: " + count);
            for (int o = 0; o < count - 1; o++)
            {
                int i = list[o];
                writer.Write("Подстрока найдена в позиции: " + i + " ");
                for (int k = i; k < i + m + 1; k++)
                    writer.Write(orig[k]);
                writer.Write("...\n");
            }
        }
        writer.WriteLine("Время работы: " + sw.ElapsedTicks + " тактов");

    }
    static void Main(string[] args)
    {
        string outpuFile = "result.txt";
        string inputFile = "wap.txt";
        using (StreamWriter writer = new StreamWriter(outpuFile, false))
        {
            using (StreamReader reader = new StreamReader(inputFile))
            {
                char c;
                int SymbolsCount = 100000;
                //int StartPosition = 0;
                //int Counter = 0;
                //string InputString = "";
                StringBuilder InputString = new StringBuilder(100000);
                StringBuilder search = new StringBuilder(1);
                search.Append('о');
                //search.Append('о');
                //int idx = 0;
                while (reader.Peek() != -1)
                {
                    c = (char)reader.Read();
                    SymbolsCount--;
                    InputString.Append(c);
                    if (SymbolsCount == 0)
                    {
                        break;
                    }
                }
                int m = search.Length;
                int n = InputString.Length;
                writer.WriteLine($"Длина строки {n}, длина искомой строки {m}");
                Pryamoy(ref InputString, ref search, n, m, writer);
                Karpa_Rabina(ref InputString, ref search, n, m, writer);
                writer.WriteLine();
            }
        }
    }
}
