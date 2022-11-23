// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// void Square(int n)

// {
//     for (int i = 1; i <= n ; i++)
// {
//     Console.WriteLine($"{i} -> {i*i}");
// }
// }
// Square(num1);

int n = -1;
while (n < 1)
{
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введены неверные данные");
}

string SqrTable(int n1)
{
    int count = 1;
    string table = "";
    while (count <= n1)
    {
        table = table + $"{count}|{count * count} \n";
        count++;
    }
    return table;
}

string sqrTable = SqrTable(n);
Console.WriteLine(sqrTable);

