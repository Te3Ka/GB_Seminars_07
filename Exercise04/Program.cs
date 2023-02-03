/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. 

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

int Diagonal(int[,] array)
{
    int sum = 0;
    int minLength = array.GetLength(0);
    if (minLength > array.GetLength(1))
        minLength = array.GetLength(1);
    for (int i = 0; i < minLength; i++)
    {
        sum += array[i, i];
    }
    return sum;
}


Console.WriteLine("Сгенерированная матрица");
int[,] array2D = CreateRandome2DArray(3, 4, 1, 9);
PrintArray(array2D);
Console.WriteLine("Сумма элементов главной диагонали = " + Diagonal(array2D));