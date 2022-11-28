// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CompDigits(int num)
{
    int comp = 1;
    for (int i = 1; i <= num; i++)
    {
        comp = comp * i;
    }
    return comp;
}
if (number > 0)
{
   int compDigits = CompDigits(number);
   Console.WriteLine($"Произведение чисел от 1 до {number} = {compDigits}");
}
else Console.WriteLine("Введите натуральное число");