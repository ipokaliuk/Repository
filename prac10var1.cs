using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        // Отримання тексту з консолі
        Console.WriteLine("Введіть текст:");
        string text = Console.ReadLine();

        // Розбиття тексту на слова
        string[] words = Regex.Split(text, @"\W+");

        // Обчислення сумарної довжини слів
        int totalLength = 0;
        foreach (string word in words)
        {
            totalLength += word.Length;
        }

        // Виведення середньої довжини слова
        Console.WriteLine("Середня довжина слова: {0}", (double)totalLength / words.Length);
    }
}
