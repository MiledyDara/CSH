// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    System.Console.Write(message);
    string numb = Console.ReadLine();
    int number = Convert.ToInt32(value);
    number = int.Parse(numb);
    return result;
}
int digit = ReadInt("Введите число");
int count=0
while(digit>0)
{
    digit/=10;
    count=count+1
}

System.Console.WriteLine(count);
