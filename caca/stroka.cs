using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string message = Console.ReadLine();
        char[] separators = { ' ', ',', '.', '!', '?' };
        string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        List<string> Max = new List<string>();
        int longestWord = 0;
        foreach (string word in words)
        {
            if (word.Length > longestWord)
            {
                longestWord = word.Length;
                Max.Clear();
                Max.Add(word);
            }
            else if (word.Length == longestWord)
            {
                Max.Add(word);
            }
        }
        //foreach (string word in words)
        //{
        //    if (word.Length < longestWord.Length)
        //    {
        //        Max.Remove(word);
        //    }
        //}
        Console.WriteLine("Самые длинные слова:");
        foreach (string str in Max)
        {
            Console.WriteLine(str);
        }
    }
}
