// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

Console.Write("Введите первое число:");
int inputDate0 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int inputDate1 = int.Parse(Console.ReadLine());
if (inputDate1 == inputDate0 * inputDate0)
Console.WriteLine("Yes");
else Console.WriteLine("No");
