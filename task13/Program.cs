// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = 0;
if (number > 99)
{ 
    while (number > 999)
    {
        number = number / 10;
    }
        thirdDigit = number % 10;
    Console.WriteLine($"{thirdDigit}");
}
else
Console.WriteLine("Третьей цифры нет");

