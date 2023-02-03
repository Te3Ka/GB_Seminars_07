void PrintArray(int[,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            if (j == arrayPrint.GetLength(1) - 1)
                Console.WriteLine($"{arrayPrint[i,j]}]");
            else
                Console.Write($"{arrayPrint[i,j]}, ");
        }
    }
}

int[,] Create2DArray(int m, int n)
{
    int[,] array2D = new int[m, n];
    
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i,j] = i + j;
        }
    }
    return array2D;
}



Console.Write("Введите высоту массива = ");
int.TryParse(Console.ReadLine(), out int m);
while (m <= 0)
{
    Console.WriteLine("Введено значение меньше 1, массив не может быть создан.\n"
                    + "Повторите ввод высоты массива:");
    int.TryParse(Console.ReadLine(), out m);
}

Console.Write("Введите ширину массива = ");
int.TryParse(Console.ReadLine(), out int n);
while (n <= 0)
{
    Console.WriteLine("Введено значение меньше 1, массив не может быть создан.\n"
                    + "Повторите ввод ширины массива:");
    int.TryParse(Console.ReadLine(), out n);
}

PrintArray(Create2DArray(m, n));