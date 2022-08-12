/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine($"число {a} больше числа {b}");
else
    Console.WriteLine($"число {b} больше числа {a}");
*/

/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("введите первое число: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число: ");
int m3 = Convert.ToInt32(Console.ReadLine());

int max = m1;

if (m2 > max) 
    max = m2;
if (m3 > max)
    max = m3;
Console.WriteLine($"число {max} максимальное");
*/

/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
    Console.WriteLine($"число {number} чётное");
else
    Console.WriteLine($"число {number} нечётное");
*/

/*
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
*/