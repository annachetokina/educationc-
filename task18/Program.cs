// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Укажите номер четверти");

int quarter = Convert.ToInt32(Console.ReadLine());

int Range (int quarter)
{
    if (quarter == 1) return x > 0 и y > 0;
    if (quarter == 2) return x < 0 и y> 0 ;
    if (quarter == 3) return (xc < 0 && yc < 0) return 3;
    if (quarter == 4) return (xc > 0 && yc < 0) return 4;
    return 0;
}

int quarter = Quarter(x, y);

string result = quarter > 0 
        ? $"Указанные координаты соответствуют четверти -> {quarter}"
        : "Введены некорректные координаты";
Console.WriteLine(result);
