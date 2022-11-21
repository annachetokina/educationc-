// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99)
{
    if(number < 1000)
    {
        int thirdDigit = number / 10;
    }
    Console.WriteLine("")
}
else
Console.WriteLine("Третьей цифры нет");
