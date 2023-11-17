// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число -> ");
string a = Console.ReadLine();
int number1 = int.Parse(a);
Console.WriteLine("Введите второе число -> ");
string b = Console.ReadLine();
int number2 = int.Parse(b);
Console.WriteLine("Введите третье число ->");
string c = Console.ReadLine();
int number3 = int.Parse(c);
int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}
System.Console.WriteLine(max);



// if (number1 > number2)
// {
//     Console.WriteLine("Max = " + number1);
// }
// else 
// {
//     Console.WriteLine("Max = " + number2);
// }
// if (number1 > number3)
// {
//     Console.WriteLine("Max = " + number1);
// }
// else
// {
//     Console.WriteLine("Max = " + number3);
// }
// if (number2 > number3)
// {
//     Console.WriteLine("Max = " + number2);
// }
// else 
// {
//     Console.WriteLine("Max = " + number3);
// }