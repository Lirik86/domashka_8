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

bool validate(int row, int col)
{
    if (row == col)
    {
        System.Console.WriteLine("Вы ввели не прямоугольный массив!");
        System.Environment.Exit(0);
    }
    return true;
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

int minimal(int[,] array)
{
    int numberStrok = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            numberStrok = i;
        }
    }
    return numberStrok+1;
}

int row = input("Введите кол-во столбцов в массиве ");
int col = input("Введите кол-во строк в массиве ");
validate(col,row);
int[,] array = myArray(col,row);
PrintArray(array);
System.Console.WriteLine($"Номер строки с минимальной суммой эллементов равен {minimal(array)}");