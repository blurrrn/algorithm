using System;

class Program
{
    static void Main(string[] args)
    {
        string message = "Дана строка, в которой содержится осмысленное текстовое сообщение";
        
        // Разделители слов
        char[] separators = { ' ', ',', '.', '!', '?' };

        // Разбиваем строку на слова
        string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        // Переменная для хранения самого длинного слова
        string longestWord = "";

        // Перебираем все слова в сообщении
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
