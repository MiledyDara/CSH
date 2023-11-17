// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadInt(string msg) // объявляем функцию РидИнт и строковый параметр msg
{
    Console.WriteLine(msg); // пишет в консоль параметр msg
    string value = Console.ReadLine();//функция считывания строки с консоли(с терминала)
    int result; //вводим переменную намбер 
    int result = Convert.ToInt32(value);// как результат преобразования строки в число 
    return result; // возврат из функции
}

int searchFactorial(number);
int i=1;
 int result = 1;
    while(i <= number){
        result *= i;
        i++;
    }
    return result;
}

int number = enterInteger("Введите число: ");
Console.WriteLine(searchFactorial(number));