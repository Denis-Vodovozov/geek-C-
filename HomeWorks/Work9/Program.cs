/*
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShowNumbers(int a, int b)
{
    if (b != a)
    {
        if (b > a)
        {
            ShowNumbers(a, b - 1);
            Console.Write(" " + b);
        }
        else
        {
            ShowNumbers(b, a - 1);
            Console.Write(" " + a);
        }
    }
    else
        Console.Write(b);
}
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(m, n);
*/

/*
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumOfNumbers(int a, int b)
{
    if (b != a)
    {
        if (b > a)
            return b + SumOfNumbers(a, b - 1);
        else
            return a + SumOfNumbers(b, a - 1);
    }
    else
        return b;
}
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumOfNumbers(m, n);
Console.WriteLine($"Сумма всех чисел в промежутке от {m} до {n} ровна {sum}");
*/

/*
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Ackerman(int a, int b)
{
    if (a == 0) 
    return b + 1;
    if (a > 0 && b == 0) 
    return Ackerman(a - 1, 1);
    if (a > 0 && b > 0) 
    return Ackerman(a - 1, Ackerman(a, b - 1));
    else
    {
        Console.WriteLine("Проверьте числа, они должны быть неотрицательными");
        return 0;
    }
}
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = Ackerman(m, n);
Console.WriteLine($"Функция Аккермана ровна {result}");
*/