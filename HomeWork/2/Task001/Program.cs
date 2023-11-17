// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
string number=Console.ReadLine(); // функция считывания строки с консоли (терминала)
int numb; // вводим переменную 
numb = int.Parse(number);
if (numb<1000 & numb>99)
    {
        int secondDigit = (numb % 100 - numb %10)/10;
        Console.WriteLine("secondDigit = " + secondDigit);
    }
else Console.WriteLine("Введено неверное число");
