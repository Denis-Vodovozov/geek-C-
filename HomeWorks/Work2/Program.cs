/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindSecDig(int num)
{
    int dec = num / 10 % 10;
    return dec;
}
int randomNumber = new Random().Next(100, 999);
int secDig = FindSecDig(randomNumber);
Console.Write($"вторая цифра числа {randomNumber} это {secDig}");
*/

/*
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void IsThirdDig(int num)
{
    if (num <= 99)
        Console.WriteLine($"в числе {num} третьей цифры нет");
    else
    {
        while (num > 999)
            num = num / 10;
        if (num <= 999)
            Console.WriteLine($"третья цифра это {num % 10}");
    }
}
Console.Write("введите число ");
int number = Convert.ToInt32(Console.ReadLine());
IsThirdDig(number);
*/

/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool FindWeekend (int daynum)
{
   if(daynum >= 6)
      return true;
   else
      return false;
}
Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
bool findday = FindWeekend(day);
Console.WriteLine(findday);
*/