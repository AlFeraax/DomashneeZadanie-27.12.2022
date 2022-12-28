//Задача 58. Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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

int[,] firstMartrix = new int[2, 2];
FillArray(firstMartrix);
Console.WriteLine("Первая матрица:");
PrintArray(firstMartrix);

int[,] secondMartrix = new int[2, 2];
FillArray(secondMartrix);
Console.WriteLine("Вторая матрица:");
PrintArray(secondMartrix);

int mult = 0;
int[,] resultMatrix = new int[2, 2];
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        mult = firstMartrix[i, j] * secondMartrix[i, j];
        resultMatrix[i, j] = mult;
    }
}

Console.WriteLine("Произведение первой и второй матриц:");
PrintArray(resultMatrix);