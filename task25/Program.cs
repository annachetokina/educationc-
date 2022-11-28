// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int Degree(int a1, int b1)
{
    int result = 1;
    int i = 1;
    while (i <= b)
    {
        result = a * result;
        i++;
    }
   return result;
}

if (b > 0)
{
  int result = Degree(a, b);
  Console.WriteLine(result);
}
else Console.WriteLine("Некорректно введенное число");



