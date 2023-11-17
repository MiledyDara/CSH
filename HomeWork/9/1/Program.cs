// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
    int m = ReadInt("Введите число m: ");
    int n = ReadInt("Введите число n: ");
    

{
void printNumbers(int m, int n)
{
    
    if (m > n)
    {
        return;
    }
    if (m % 2 == 0)
    {
        System.Console.Write($"{m} \t");
    }
    printNumbers(m+1, n);
}
    printNumbers (m, n);
}


