int[,,] createUniqueArr(int x, int y, int z, int min, int max)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while (k < result.GetLength(2))
            {
                int number = new Random().Next(min, max + 1);
                if (findArrElement(result, number))
                {
                    result[i, j, k] = number;
                    k++;
                }
            }
        }
    }
    return result;
}


bool findArrElement(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) return false;
            }
        }
    }
    return true;
}
void printArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
Console.Write("Введите размерность массива:\nПервая: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Третья: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array = createUniqueArr(x, y, z, 10, 99);
printArray(array);
