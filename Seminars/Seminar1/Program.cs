/*
// Задача 1.

Console.Write("введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int quad = num * num;

Console.WriteLine($"квадрат из числа {num} это {quad}");
*/

/*
// Задача 2.

Console.Write("введите первое число ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if (n1 == quad2)
{
    Console.WriteLine($"число {n1} это квадрат числа {n2}");
}
else
{
    Console.WriteLine($"число {n1} это не квадрат числа {n2}");
}
*/

/*
// Задача 3.

Console.Write("введите целое положительное число ");
int number = Convert.ToInt32(Console.ReadLine());

int current = number * (-1);

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}
*/


// Задача 4.

Console.Write("введите целое трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

int ed = num % 10;

Console.WriteLine($"последнее цифра числа {num} это {ed}");