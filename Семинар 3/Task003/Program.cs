// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

int EnterCoordinate(string message);
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    return double.Parse(value);
}
double resolveDistance(double x, double y, double x2, double y2){
    double xDistance = (x-x2);
    double yDistance = (y-y2);
    double distance = Math.Sqrt(xDistance*xDistance + yDistance*yDistance);
    return distance;
}
double x = EnterCoordinate("Введите координату x ");

    