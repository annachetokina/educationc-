// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.


Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Weekend(num1) ? "Да" : "Нет");

bool Weekend (int number)

{
    return (num1 == 6) || (num1 == 7);
}

