// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int c = 1;
// if (b < 1)
//     Console.Write("Число B должно быть натуральным\n");
// else
// {
//     while (b != 0)
//     {
//         c = c * a;
//         b = b - 1;
//     }
//     Console.Write($"Число A в натуральной степени B равно { c}");
// }


Console.WriteLine("Enter number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b > 1) // задаём условиие, при котором число B считается натуральным
{
    Console.WriteLine($"Число A в степени B равно {Math.Pow(a,b)}"); // вывод в консоль результата
}
else Console.WriteLine("B - ненатуральное число"); // вывод в консоль сообщения, если число B меньше или равно 0

