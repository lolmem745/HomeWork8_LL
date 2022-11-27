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
int minLineFinder(int[,] arr)
{

    int index = 0;
    int[] temp = { 0, 0 };
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
            index = i;

        }
        if (i != 0)
        {
            if (sum < temp[1])
            {
                temp[0] = index + 1;
                temp[1] = sum;
            }
        }
        else
        {
            temp[0] = index + 1;
            temp[1] = sum;
        }
    }
    return temp[0];
}
Console.Write("Введите размерность массива:\nСтроки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
fillArray(arr);
printArray(arr);
var res = minLineFinder(arr);
Console.WriteLine($"Строка с минимальной суммой элементов: {res}");
