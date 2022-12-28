//Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(1, 11);
}
}
}

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}
}

int SumNumInLine(int[,] array, int i)
{
int sumLine = array[i, 0];
for (int j = 1; j < array.GetLength(1); j++)
{
sumLine += array[i, j];
}
return sumLine;
}

int[,] array = new int[7, 3];
FillArray(array);
PrintArray(array);

int minSumLine = 0;
int sumLine = SumNumInLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
int tempSumLine = SumNumInLine(array, i);
if (sumLine > tempSumLine)
{
sumLine = tempSumLine;
minSumLine = i;
}
}
Console.WriteLine();
Console.WriteLine($"({minSumLine + 1}) - строкa с наименьшей суммой элементов, равной ({sumLine}).");