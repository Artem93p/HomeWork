// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();


double Lenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1,2));
    return result;
}
int coordinate(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int x1 = coordinate("Введите координаты X1 = ");
int y1 = coordinate("Введите координаты Y1 = ");
int z1 = coordinate("Введите координаты Z1 = ");
int x2 = coordinate("Введите координаты X2 = ");
int y2 = coordinate("Введите координаты Y2 = ");
int z2 = coordinate("Введите координаты Z2 = ");

double result = Lenght(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(result,2));