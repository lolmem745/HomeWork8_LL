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

}
int m = 4;
int n = 4;
int[,] arr = new int[m, n];
int number = 1;
for (int i = 0; i < n; i++) // Заполняем периметр
{
    arr[0, i] = number;
    number++;
}
for (int i = 1; i < m; i++)
{
    arr[i, n - 1] = number;
    number++;
}
for (int i = n - 2; i >= 0; i--)
{
    arr[m - 1, i] = number;
    number++;
}
for (int i = m - 2; i > 0; i--)
{
    arr[i, 0] = number;
    number++;
}
int m1 = 1;
int n1 = 1;
while (number < m * n)
{
    while (arr[m1, n1 + 1] == 0) // Вправо
    {
        arr[m1, n1] = number;
        number++;
        n1++;
    }
    while (arr[m1 + 1, n1] == 0) // Вниз
    {
        arr[m1, n1] = number;
        number++;
        m1++;
    }
    while (arr[m1, n1 - 1] == 0) // Влево
    {
        arr[m1, n1] = number;
        number++;
        n1--;
    }
    while (arr[m1 - 1, n1] == 0) //Вверх
    {
        arr[m1, n1] = number;
        number++;
        m1--;
    }
}
for (int i = 0; i < m; i++) // Заполнение последнего символа
{
    for (int j = 0; j < n; j++)
    {
        if (arr[i, j] == 0)
        {
            arr[i, j] = number;
        }
    }
}


printArray(arr);