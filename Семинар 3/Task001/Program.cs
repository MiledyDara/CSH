// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка

int EnterCoordinate(string message);
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    return int.Parse(value);
}
bool checkValidate(int x, int y)
{
    if (x == 0 || y == 0) {
        System.Console.WriteLine("Координата X или Y равна нулю");
        return false;
    }
}
int checkCategory(int x, int y){
    if(x > 0 && y > 0){
        return 1;
    }
    if (x < 0 && y < 0) {
        return 3;
    }
    return 4;
}
int x = EnterCoordinate("Введите координату x ");
int y = EnterCoordinate("Введите координату y ");

if(checkValidate(x, y)){
    System.Console.WriteLine("Номер четверти равен " + checkCategory(x, y));
}