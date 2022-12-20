/*  **Задача 60**
 ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int x, y, z;
Console.WriteLine("Enter the x dimension of the array: ");
int.TryParse(Console.ReadLine()!, out x);
Console.WriteLine("Enter the y dimension of the array: ");
int.TryParse(Console.ReadLine()!, out y);
Console.WriteLine("Enter the z dimension of the array: ");
int.TryParse(Console.ReadLine()!, out z);
Console.WriteLine();
int[,,] array = new int[x, y, z];
int[] nums = new int[90];
for (int i = 0; i < 90; i++)
{
    nums[i] = i + 10;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            int temp = new Random().Next(90);
            while (nums[temp] == 0)
                temp = new Random().Next(90);
            array[i, j, k] = nums[temp];
            nums[temp] = 0;
            Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
        }
        Console.WriteLine();
    }
}
