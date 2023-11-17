// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int readQuoter (string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    return int.Parse(value);
}
int quoter = readQuoter("Введите номер четверти ");
if (quoter>0 && quoter<5)
{
    switch (quoter)
    {
        case 1: System.Console.WriteLine("Координаты x и y принимают значение больше 0"); break;
        case 2: System.Console.WriteLine("Координата x<0, y>0"); break;
        case 3: System.Console.WriteLine("Координаты x и y принимают значение меньше 0"); break;
        default: System.Console.WriteLine("Координата x>0, y>0"); break;
    }
}


// int readQuoter (string message)
// {
//     System.Console.WriteLine(message);
//     string value = Console.ReadLine();
//     return int.Parse(value);
// }
// int quoter = readQuoter("Введите номер четверти ");
// if (quoter>0 && quoter<5)
// {
//     if(quoter==1)
//     {
//     System.Console.WriteLine("Координаты x и y принимают значение больше 0");
//     }
//     if(quoter==2)
//     {
//     System.Console.WriteLine("Координата x<0, y>0");
//     }
//     if(quoter==3)
//     {
//     System.Console.WriteLine("Координаты x и y принимают значение меньше 0");
//     }
//     if(quoter==4)
//     {
//     System.Console.WriteLine("Координата x>0, y>0");
//     }
// }
// else System.Console.WriteLine("Данные введены неверно");