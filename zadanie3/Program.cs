int input(string msg)
{
    System.Console.WriteLine($"{msg} >");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int[,] myArray(int col, int row)
{
    int[,] array = new int[col, row];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,10);
        }
    }
    return array;
}

int[,] requstArray(int[,] matrix1, int[,] matrix2)
{
    int[,] array = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = 0;
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    array[i,j] = array[i,j] + matrix1[i,k]*matrix2[k,j];
                }
            }
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

int col1 = input("Введите количество столбцов для первой матрицы: ");
int row1 = input("Введите количество строк для первой матрицы: ");
int col2 = input("Введите количество столбцов для второй матрицы: ");
int row2 = input("Введите количество строк для второй матрицы: ");
int[,] matrix1 = myArray(col1,row1);
int[,] matrix2 = myArray(col2,row2);
PrintArray(matrix1);
System.Console.WriteLine();
PrintArray(matrix2);
int[,] array = requstArray(matrix1, matrix2);
PrintArray(array);