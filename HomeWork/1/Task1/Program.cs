// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число -> ");
string a = Console.ReadLine();
int number1 = int.Parse(a);
Console.WriteLine("Введите второе число -> ");
string b = Console.ReadLine();
int number2 = int.Parse(b);
if (number1==number2)
{
    Console.WriteLine("Введённые числа равны");
}
else if (number1 > number2)
{
    Console.WriteLine("Первое число " + number1  +  " больше второго числа " + number2);
}
else
{
    Console.WriteLine("Второе число " + number2 + " больше первого числа " + number1);
}