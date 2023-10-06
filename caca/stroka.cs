using System;

class Program
{
    static void Main(string[] args)
    {
        string message = "Дана строка, в которой содержится осмысленное текстовое сообщение";
        char[] separators = { ' ', ',', '.', '!', '?' };
        string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        Console.WriteLine("Самое длинное слово: " + longestWord);
    }
}
