using System;

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
