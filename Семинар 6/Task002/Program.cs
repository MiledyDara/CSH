// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    string a = Console.ReadLine();
    int numb;
    numb = int.Parse(a);
    return numb;
}

int [] binaryArray(int number)
{
    int [] binary = new int[8];
    for (int i=binary.Length-1; i >=0; i--)
    {
        binary[i]=number%2;
        number=number/2;
    }
    return binary;
}
void printArray(int[] array)
{
    Console.Write(array[0]);
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
 }

int number = ReadInt("Введите число больше 0");
printArray(binaryArray(number));
