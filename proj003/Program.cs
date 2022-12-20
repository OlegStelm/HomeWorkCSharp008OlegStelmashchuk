/*  **Задача 58**
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int a1, a2, b1, b2;
Console.WriteLine("Enter the a1 dimension of the array: ");
int.TryParse(Console.ReadLine()!, out a1);
Console.WriteLine("Enter the a2 dimension of the array: ");
int.TryParse(Console.ReadLine()!, out a2);
Console.WriteLine("Enter the b1 dimension of the array: ");
int.TryParse(Console.ReadLine()!, out b1);
Console.WriteLine("Enter the b2 dimension of the array: ");
int.TryParse(Console.ReadLine()!, out b2);
Console.WriteLine();
int[,] array = new int[a1, a2];
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
int[,] array2 = new int[b1, b2];
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = new Random().Next(10);
        Console.Write($"{array2[i, j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] array3 = new int[a1, b2];
if (a2 != b1)
{
    Console.WriteLine("Multiplication is impossible! Specify a different matrices size.");
}
else
{
    for (int c1 = 0; c1 < array3.GetLength(0); c1++)
    {
        for (int c2 = 0; c2 < array3.GetLength(1); c2++)
        {
            int sum = 0;
            for (int n = 0; n < array.GetLength(1); n++)
            {
                sum += array[c1, n] * array2[n, c2];
            }
            array3[c1, c2] = sum;
            Console.Write($"{array3[c1, c2]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
