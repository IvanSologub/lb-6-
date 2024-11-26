using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку S: ");
        string S = Console.ReadLine();

        Console.Write("Введите строку So: ");
        string So = Console.ReadLine();

        int count = CountOccurrences(S, So);
        Console.WriteLine($"Количество вхождений строки '{So}' в строку '{S}': {count}");
    }

    static int CountOccurrences(string S, string So)
    {
        if (string.IsNullOrEmpty(S) || string.IsNullOrEmpty(So))
        {
            return 0; // Если одна из строк пустая, возвращаем 0
        }

        int count = 0;
        int index = 0;

        // Ищем все вхождения строки So в строке S
        while ((index = S.IndexOf(So, index)) != -1)
        {
            count++;
            index += So.Length; // Переходим к следующему символу после найденного вхождения
        }

        return count;
    }
}
