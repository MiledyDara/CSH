// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int newNum = num%10;
System.Console.WriteLine(GetSum(num));
int GetSum(int newNum);

{
    sum += newNum % 10;
    if (newNum == 0)
    {
        return sum;
    }
    return GetSum(newNum / 10);
}
