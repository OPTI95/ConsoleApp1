using System;
namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        // Подсчет суммы цифр для каждого месяца всех дней в году
        for (int month = 1; month <= 12; month++)
        {
            Console.WriteLine($"Месяц {month}:");
            for (int day = 1; day <= DateTime.DaysInMonth(DateTime.Now.Year, month); day++)
            {
                int dateSum = DigitSum(day);
                Console.WriteLine($"День {day}: Сумма цифр - {dateSum}");
            }
            Console.WriteLine();
        }
    }

    // Функция для подсчета суммы цифр числа
    static int DigitSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}


public static class MathFunctions
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        return n * Factorial(n - 1);
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}

public static class StringFunctions
{
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static bool IsPalindrome(string input)
    {
        string reversed = ReverseString(input);
        return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}