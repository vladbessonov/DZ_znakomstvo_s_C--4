//  Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. Не использовать Math.Pow

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Ввод исходного значения:
Console.Write("Введите число А:  ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B:  ");
double b = Convert.ToDouble(Console.ReadLine());

//Проверка натуральности числа В:
if (b < 0 || b % 1 != 0)
{
    Console.Write($"Число {b} - не является натуральным");
    return;
}

// Возведение в степень:
int MyPow(int a, double b)
{
    int stepen = 1;
    for (int i = 1; i <= b; i++)
    {
        stepen = stepen * a;
    }
    return stepen;
}
Console.Write($"Число {a} в степени числа {b} равно {MyPow(a, b)}");

