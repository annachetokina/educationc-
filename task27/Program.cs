// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
  int count = 0;
  int sum = 0;
  int a1 = num / 10;
  while (num > 0)
   {
    num = num % 10;
    sum = sum + num;
    count++;
   }
  int res = a1 + sum;
  return res;
}

if (number < 0) number = -number;
{
 int result = SumDigit(number);
 Console.WriteLine($"Сумма цифр в числе {number} ---> {result}");
}




// int Digits(int num)
// { 
//     int count = 0;
    
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count == 0 ? 1 : count;
// }

// if (number < 0) number = -number;
// {
//  int result = Digits(number);
//  Console.WriteLine($"Количество цифр в числе {number} ---> {result}");
// }