// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.


Console.WriteLine("Введите число от 100 до 999:");

int num = Convert.ToInt32(Console.ReadLine());

if( num > 999) 
Console.WriteLine("Некорректно введенное число");

if(num < 1000)
Console.WriteLine("Некорректно введенное число");


int ShowSecondDigit(int numb)

{
    int secondDigit = numb % 100;
    int result = secondDigit / 10 ;
    return result;
}

Console.WriteLine(ShowSecondDigit(num));



