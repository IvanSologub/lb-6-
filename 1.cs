using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите символ: ");
        char c = Console.ReadKey().KeyChar; // Считываем символ с клавиатуры
        Console.WriteLine(); // Переход на новую строку

        if (char.IsDigit(c))
        {
            Console.WriteLine("digit");
        }
        else if (char.IsLetter(c))
        {
            // Проверяем, является ли буква латинской или русской
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                Console.WriteLine("lat");
            }
            else if ((c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я'))
            {
                Console.WriteLine("rus");
            }
            else
            {
                Console.WriteLine("Неизвестный символ");
            }
        }
        else
        {
            Console.WriteLine("Неизвестный символ");
        }
    }
}
