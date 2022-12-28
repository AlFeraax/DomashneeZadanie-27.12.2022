//Задача 60.Сформируйте трёхмерный массив из двузначных чисел размером 2 x 2 x 2. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillArray(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                array3d[i, j, k] = new Random().Next(1, 10);
            }
        }
    }
}

void PrintArray(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i, j, k]} ({i},{j},{k}) |");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array3d = new int[2, 2, 2];
FillArray(array3d);
PrintArray(array3d);