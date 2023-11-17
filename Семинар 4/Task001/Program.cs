// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadInt(string message)
{
    Console.Write(message);
    string numb = Console.ReadLine();
    int number;
    int number = Convert.ToInt32(numb);
    return number;
}
int result = ReadInt("Введите число больше 0: ");
int searchSum(result);
int sum=0;
while (result > 0)
{
    sum=sum+result;
    result--;
}

Console.WriteLine("Сумма чисел от 1 до {result} равна " + sum);