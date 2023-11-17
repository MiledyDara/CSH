// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9

bool CheckEnteredNumbers(int min, int max, int k)
{
    if (min >= 0 && max >= min && k > 0)
    {
        return true;
    }
    return false;
}

int[] GenerateArray(int minLimitRandom, int maxLimitRandom, int k)
{
    int[] numbersArray = new int[k];
    Random random = new Random();
    for (int i = 0; i < numbersArray.Length; i++)
    {
        numbersArray[i] = random.Next(minLimitRandom, maxLimitRandom + 1);
    }
    return numbersArray;
}


void PrintArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length - 1; i++)
    {

        Console.Write($"{matrix[i]}, ");

    }
    System.Console.Write($"{matrix[matrix.Length - 1]}");
    Console.WriteLine();
}

void PrintBigArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int m = 0; m < matrix.GetLength(1); m++)
        {
            Console.Write($"{matrix[i, m]}\t");
        }
    }
    Console.WriteLine();
}

int ReadConsoleToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int CountFindingNumbers(int[] array, int numberOfCount)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (numberOfCount == array[i])
        {
            count++;
        }
    }
    return count;
}

int[,] CreateArrayForCounterNumber(int[] array, int minLimitRandom, int maxLimitRandom)
{
    int[,] arrayCount = new int[2, maxLimitRandom - minLimitRandom + 1];
    int count = 0;
    for (int i = 0; count < arrayCount.GetLength(1); i++)
    {
        arrayCount[0, i] = minLimitRandom + count;
        count++;
    }
    for (int j = 0; j < arrayCount.GetLength(1); j++)
    {
        arrayCount[1, j] = CountFindingNumbers(array, minLimitRandom + j);
    }
    return arrayCount;
}

System.Console.Clear();
System.Console.WriteLine("Программа позволяет составить частотный словарь элементов\nдля двумерного массива целых положительных чисел\n");
int minLimitRandom = ReadConsoleToInt("Введите минимальное целое положительное число для массива: ");
int maxLimitRandom = ReadConsoleToInt("Введите максимальное целое положительное число в массиве: ");
int lengthArray = ReadConsoleToInt("Введите кол-во чисел в матрице: ");

if (CheckEnteredNumbers(minLimitRandom, maxLimitRandom, lengthArray))
{

    int[] userArray = GenerateArray(minLimitRandom, maxLimitRandom, lengthArray);
    PrintArray(userArray);
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество чисел, в матрице состоящей из чисел от {minLimitRandom} до {maxLimitRandom}");
    PrintBigArray(CreateArrayForCounterNumber(userArray, minLimitRandom, maxLimitRandom));
}
else
{
    System.Console.WriteLine("Введены не корректные значения!\nерезапустите программу и попробуйте еще раз.");
}