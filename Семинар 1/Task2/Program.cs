// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

Console.Write("Введите число от 1 до 7 -> ");
int number1 = int.Parse(Console.ReadLine());
string[]week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
if (number1 >=1 && number1<=7)
{
    System.Console.WriteLine(week[number1-1]);
}
else
{
    Console.WriteLine("Ввели число отичное от 1-7");
}
// {
//     Console.WriteLine("Понедельник");
// }
// else if (number1 == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (number1 == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (number1 == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (number1 == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (number1 == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (number1 == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else 
// {
//     Console.WriteLine("Введено неверное число");
// }