﻿// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Multipicity(number) ? "Да" : "Нет");

bool Multipicity(int num1)
{
    return (num1 % 7 == 0) && (num1 % 23 == 0);
}
