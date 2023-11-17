// Напишите программу, которая принимает на вход число (N) и выдаёт список квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int ReadInt (string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    return int.Parse(value);
}
int  N = ReadInt("Введите число ");
if (N>0)
{
    int Index = 0;
    while(Index<N) 
    {
        Index++;
        System.Console.WriteLine(Index*Index);
    }
 }
 else System.Console.WriteLine("Нужно вводить только положительные числа");