// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число от 10000 до 99999");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome(int num)
{
    int number1 = number / 10000;
    int number2 = number1 / 1000;
    int number3 = number2 / 100;
    int number4 = number3 / 10;
    int number5 = number % 10;

    if (number1 == number5 && number2 ==number4) return true;
    return false;
}

bool result = Palindrome(number);

if(number < 10000 || number > 99999)
    Console.WriteLine("Некорректно введенное число");
else
    Console.WriteLine(result ? "-> да" : "-> нет");