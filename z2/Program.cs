// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
//82 -> 10
//9012 -> 12

// Ввод исходного значения:
Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());

// Функция вычисления суммы цифр числа:
int SumDigit(int number)
{
    int sum = 0;
    int temp = number;
    while (temp > 0)
    {
        sum = sum + temp % 10;
        temp = temp / 10;
    }
    return sum;
}
// вывод результата:
Console.Write($"Сумма цифр в числе {number} равна  {SumDigit(number)}.");