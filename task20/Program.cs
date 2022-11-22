// Задача 20: Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 2D
//    пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки XA");
int xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки YA");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки XB");
int xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки YB");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance(int xa1, int ya1, int xb1, int yb1)
{
    double xc = (xa1 - xb1) * (xa1 - xb1);
    double yc = (ya1 - yb1) * (ya1 - yb1);
    double result = Math.Sqrt(xc + yc);
    return result;
}

double res = Distance(xa, ya, xb, yb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);