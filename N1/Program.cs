void fillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }

    }
}
void printArray(int[,] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
            if (j != arr.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i == arr.GetLength(0) - 1) Console.Write("]");
        Console.Write($"\n");

    }
    Console.Write($"\n");
}
void arrLineSort(int[,] arr)
{
    int k = 0;
    while (k < arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = temp;
                }
            }

        }
        k++;
    }
}
Console.Write("Введите размерность массива:\nСтроки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
fillArray(arr);
printArray(arr);
arrLineSort(arr);
Console.WriteLine("Массив с упорядоченными по убыванию элементами строк: ");
printArray(arr);