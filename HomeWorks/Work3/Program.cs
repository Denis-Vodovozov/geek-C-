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

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

