// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки XA");
int xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки YA");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки ZA");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки XB");
int xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки YB");
int yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки ZB");
int zb = Convert.ToInt32(Console.ReadLine());


double Distance(int xa1, int ya1, int za1, int xb1, int yb1, int zb1)
{
    double xc = (xa1 - xb1) * (xa1 - xb1);
    double yc = (ya1 - yb1) * (ya1 - yb1);
    double zc = (za1 - zb1) * (za1 - zb1);
    double result = Math.Sqrt(xc + yc + zc);
    return result;
}

double res = Distance(xa, ya, za, xb, yb, zb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);