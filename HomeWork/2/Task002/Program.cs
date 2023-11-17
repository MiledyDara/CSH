// Напишите программу, которая принимает на вход некоторое число и на выходе показывает третью цифру этого числа, а при её отсутствии - соответствующее сообщение.
// 456 -> 5
// 78 -> третьей цифры нет
// 94158 -> 1


int Prompt(string msg)
{

    System.Console.WriteLine($"{ msg}");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");

int fnumber(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool check(int number)
{
    if (number < 100)
        return false;
    else return true;
}

if (check(number) != true)
    System.Console.WriteLine("Третьей цифры нет");
else
    System.Console.WriteLine($"Третьей цифрой числа { number} является {fnumber(number)}");



// Console.WriteLine("Введите число");
// string number=Console.ReadLine(); // функция считывания строки с консоли (терминала)
// int numb; // вводим переменную 
// numb = int.Parse(number);
// if (numb<100000 & numb>99)
//     {
//         int ThirdDigit = (numb % 1000 - numb%10)/100;
//         Console.WriteLine("ThirdDigit = " + ThirdDigit);
//     }
// else Console.WriteLine("Третьей цифры нет");