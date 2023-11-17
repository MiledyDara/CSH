// Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

System.Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

PrintNumbers(num1, num2);

void PrintNumbers(int start, int end)
{
    System.Console.Write(start+ ", ");
    
    if (start == end)
    {
        return;
    }
    else
    {
        PrintNumbers(start+1, end);
    }
}
