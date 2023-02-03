/*
Решение в группах задач:
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/

void PrintArray(int[,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            if (j == arrayPrint.GetLength(1) - 1)
                Console.WriteLine($"{arrayPrint[i, j]}]");
            else
                Console.Write($"{arrayPrint[i, j]}, ");
        }
    }
}

int[,] CreateRandome2DArray(int m, int n, int min, int max)
{
    int[,] array2D = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = random.Next(min, max + 1);
        }
    }
    return array2D;
}

int[,] QadratArray(int[,] oldArray)
{
    for (int i = 0; i < oldArray.GetLength(0); i += 2)
    {
        for (int j = 0; j < oldArray.GetLength(1); j += 2)
        {
            oldArray[i, j] *= oldArray[i, j];
        }
    }
    return oldArray;
}

Console.WriteLine("Сгенерированная матрица");
int[,] array = CreateRandome2DArray(3, 4, 1, 9);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Новая матрица");
PrintArray(QadratArray(array));