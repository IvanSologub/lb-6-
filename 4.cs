using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string result = NormalizeSpaces(input);

        Console.WriteLine($"Результат: '{result}'");
    }

    static string NormalizeSpaces(string input)
    {
        // Удаляем ведущие и замыкающие пробелы, а затем заменяем несколько пробелов на один
        return System.Text.RegularExpressions.Regex.Replace(input.Trim(), @"s+", " ");
    }
}
