int[,] myArray(int num)
{
    int[,] array = new int[num, num];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = 0;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}\t");
        }
    }
    System.Console.WriteLine();
}

int[,] requstArray(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do {array[i, j++] = value++;} while (++k < n-1);
        for (k = 0; k< n-1; k++) array[i++, j] = value++;
        for (k = 0; k< n-1; k++) array[i, j--] = value++;
        for (k = 0; k< n-1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0:n-2;
    }
    return array;
}
int num = 6;
int [,] array = myArray(num);
PrintArray(array);
PrintArray(requstArray(array, num));