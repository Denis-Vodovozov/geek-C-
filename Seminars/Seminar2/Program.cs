// Задача 1.
/*
int FindBigDig(int number)
{
    int ed = number % 10;
    int dec = number / 10;
    int max;

    if(ed > dec)
        max = ed;
    else
        max = dec;
        
    return max;
}
int randNum = new Random().Next(10,100);
int bigDig = FindBigDig(randNum);
Console.Write($"Большая цифра из числа {randNum} это {bigDig}");
*/

// Задача 2.
/*
int CutNum(int num)
{
    int ed = num % 10;
    int sot = num / 100;

    return sot * 10 + ed;
}
int randNum = new Random().Next(10,1000);
int newNum = CutNum(randNum);
Console.Write($"новая версия числа {randNum} это {newNum}");
*/


// Задача 3.
/*
void IsDiv(int num1, int num2)
{
    int reminder = num2 % num1;
    if(reminder == 0)
    Console.WriteLine($"число {num2} кратно числу {num1}");  
    else
    Console.WriteLine($"число {num2} не кратно числу {num1}. Остаток от деления {reminder}"); 
}
Console.Write("введите первое число ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int n2 = Convert.ToInt32(Console.ReadLine());
IsDiv(n1, n2);
*/

// Задача 4.
/*
bool IsDiv(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}
Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

bool IsDivision = IsDiv(n);
Console.WriteLine(IsDivision);
*/