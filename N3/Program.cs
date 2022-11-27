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
Console.Write("Введите размерность первого массива:\nСтроки: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцы: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность второго массива:\nСтроки: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцы: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 == m2)
{
    int[,] arr1 = new int[m1, n1];
    fillArray(arr1);
    int[,] arr2 = new int[m2, n2];
    fillArray(arr2);
    int[,] resArr = new int[m1, n2];

    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            int k = 0;

            for (int f = 0; f < arr1.GetLength(1); f++)
            {
                k = k + arr1[i, f] * arr2[f, j];
            }
            resArr[i, j] = k;
        }
    }
    printArray(arr1);
    printArray(arr2);
    printArray(resArr);
}
else Console.Write("\nПроизведения таких массивов не может существовать. Проверьте размерность.");
