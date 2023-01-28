// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Сделать через функции

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] CreatArray(int size)
{
    //создаем новый массив
    int[] massiv = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnd.Next(0, 100);//в массиве будут положительные числа от 0 до 99 включительно
    }
    return massiv;
}
void PrintArray(int[] array) //функция вывода массива
{
    for (int i = 0; i < array.Length; i++)
    {
         System.Console.Write(array[i] + ", " ); //выводим массив в одну строку через пробел c добавлением []
    }
}

int[] array = CreatArray(8); // массив array имеет размер 8 
PrintArray(array);











