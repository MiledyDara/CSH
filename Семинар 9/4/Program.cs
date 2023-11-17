// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

System.Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine(GetSum(num1, num2));

int GetSum(int num, int degree)
{
    if(degree==0)
    {
        return 1;
    }
    else if(degree==1)
    {
        return num;
    }
    return num * GetSum(num, degree-1);
}
