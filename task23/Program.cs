// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N


int n = -1;
while (n < 1)
{
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введены неверные данные");
}

void Cube(int num)

{
    for (int i = 1; i <= n ; i++)
{
    Console.WriteLine($"{i} -> {i*i*i}");
}
}
Cube(n);
