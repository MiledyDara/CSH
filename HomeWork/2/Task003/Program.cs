// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число -> ");
string a = Console.ReadLine();
int number = int.Parse(a);
if (number > 0 && number < 6)
{
    Console.WriteLine(number + "  нет, это будний день");
}
else if (number > 5 && number < 8)
{
    Console.WriteLine(number + "  да, это выходной");
}
