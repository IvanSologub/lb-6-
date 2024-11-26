using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите арифметическое выражение (например, 4+7-2-8): ");
        string expression = Console.ReadLine();
        
        int result = CalculateExpression(expression);
        
        Console.WriteLine($"Результат: {result}");
    }

    static int CalculateExpression(string expression)
    {
        int sum = 0;
        int currentNumber = 0;
        char currentOperation = '+'; // Начинаем с операции сложения
        
        for (int i = 0; i < expression.Length; i++)
        {
            char c = expression[i];

            // Если символ - цифра, формируем текущее число
            if (char.IsDigit(c))
            {
                currentNumber = currentNumber * 10 + (c - '0'); // Конвертируем символ в число
            }

            // Если символ - оператор или последний символ строки
            if (c == '+' || c == '-' || i == expression.Length - 1)
            {
                // Если это последний символ, нужно учесть последнее число
                if (i == expression.Length - 1 && char.IsDigit(c))
                {
                    currentNumber = currentNumber * 10 + (c - '0');
                }

                // Применяем предыдущую операцию
                if (currentOperation == '+')
                {
                    sum += currentNumber;
                }
                else if (currentOperation == '-')
                {
                    sum -= currentNumber;
                }

                // Сохраняем текущую операцию и сбрасываем текущее число
                currentOperation = c;
                currentNumber = 0;
            }
        }

        return sum;
    }
}
