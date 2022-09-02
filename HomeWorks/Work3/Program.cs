//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
// первый вариант
void Palindrom (int number)
{
    int digit1 = (number % 100000) / 10000;
    int digit2 = (number % 10000) / 1000;
    int digit3 = (number % 1000) / 100;
    int digit4 = (number % 100) / 10;
    int digit5 = number % 10;
    if (digit1 == digit5 && digit2 == digit4)
        Console.WriteLine($"число {number} полиндром");
    else
        Console.WriteLine($"число {number} не полиндром");
}
*/
/*
void Palindrom(int number)
{
    int temp = number;
    int revers = 0;
    while (number > 0)
    {
        int digit = number % 10;
        revers = revers * 10 + digit;
        number = number / 10;
    }
        if (temp == revers)
            Console.WriteLine($"число полиндром");
        else
            Console.WriteLine($"число не полиндром");
}
Console.Write("введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);
*/

/*
//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
Console.Write("Введите координату первой точки по оси Х: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату первой точки по оси У: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату первой точки по оси Z: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату второй точки по оси Х: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату второй точки по оси У: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату второй точки по оси Z: ");
double zb = Convert.ToDouble(Console.ReadLine());
double distance = FindDistance(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Расстояние между двумя точками равно {distance}");
*/
/*
//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void ShowQube(int n)
{
    int current = 1;
    while (current <= n)
    {
        Console.WriteLine($"Куб числа {current} = {current * current * current}");
        current++;
    }
}
Console.Write("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowQube(number);
*/


