using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        string message = Console.ReadLine();
        char[] separators = { ' ', ',', '.', '!', '?' };
        string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        List<string> Max = new List<string>();
        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
                Max.Clear();
            }
            else if (word.Length == longestWord.Length)
            {
                Max.Add(word);
            }
        }
        Console.WriteLine("Самое длинное слово: " + longestWord);
    }
}
