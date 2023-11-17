// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

// int enterInteger(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
int[,] matrix = new int[3,4];

void createMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }
}
    int[,] changeMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int mean=matrix[0,i];
            matrix[0,i]=matrix[matrix.GetLength(0)-1,i];
            matrix[matrix.GetLength(0)-1,i]=mean;
        }
    return matrix;
    }
    void printMatrix(int[,] matrix)
    { for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
    }
    createMatrix(matrix);
    printMatrix(matrix);
    Console.WriteLine();
    Console.WriteLine();
    changeMatrix(matrix);
    printMatrix(matrix);

// int[,] generateArray(int countCollums, int countLine, int a, int b){
//     int[,] array = new int[countLine, countCollums];
//     for (int i = 0; i < countCollums; i++)
//     {
//         for (int m = 0; m < countLine; m++)
//         {
//             array[m, i] = m+i;
//         }
//     }
//     return array;
// }

// void printMassive(int[,] collection){
//     for (int i = 0; i < collection.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int m = 0; m < collection.GetLength(1); m++)
//         {
//             Console.Write($"{collection[i, m]} \t");
//         }
//     }
//     Console.WriteLine();
// }

// int countCollums = enterInteger("Введите количество колоннок массива: ");
// int countLine = enterInteger("Введите количество строк массива: ");

// int[,] array = generateArray(countCollums, countLine, 1, 9);
// printMassive(array);