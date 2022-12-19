/*  **Задача 56**
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int m, n;
Console.WriteLine("Enter the m dimension of the array: ");
int.TryParse(Console.ReadLine()!, out m);
Console.WriteLine("Enter the n dimension of the array: ");
Console.WriteLine();
int.TryParse(Console.ReadLine()!, out n);
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[] array2 = new int[array.GetLength(0)];
for (int i = 0, s = 0; i < array.GetLength(0); i++, s++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    array2[s] = sum;
    Console.Write($"{array2[s]}  ");
}
Console.WriteLine();
int minIndex = 1;
int min = array2[0];
for (int s = 0; s < array2.Length; s++)
{
    if (array2[s] < min)
    {
        min = array2[s];
        minIndex = s + 1;
    }
}
Console.WriteLine();
Console.Write($"Minimum sum of elements in row - {minIndex}");
