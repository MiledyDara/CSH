// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetRandom2DArray(int start, int end, int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = new Random().Next(start, end+1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write($"{array[i, j]} + \t");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(double[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        System.Console.Write($"{arr[i]:f2} + \t");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    
    Console.ResetColor();
}

double[] GetAVGInArray(int[,] array)
{
    double[] avgArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)// здесь проверка по столбцам
    {
        double result = 0;
        for (int j = 0; j < array.GetLength(0); j++)//здесь проверка по строкам
        {
            result = result + array[j, i];//j - здесь строки, i - здесь столбцы, т.к. так обозначены условия
        }
        avgArray[i] = result / array.GetLength(0);
    }
    return avgArray;
}

int userArrayRow = TakeEnteredNumber("Введите количество строк:");
int userArrayColumn = TakeEnteredNumber("Введите количество столбцов:");
int userArrayStart = TakeEnteredNumber("Введите начало диапазона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапазона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);
System.Console.WriteLine();
double[] resultArray = GetAVGInArray(user2DArray);
PrintArray(resultArray);

