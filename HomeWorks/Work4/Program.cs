/*
// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Сonstruction (int numA, int numB)
{
    int count = 1; 
    for (int i = 1; i <= numB; i++)
        count = count * numA;            
    return count;
}
Console.Write("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = Сonstruction(a, b);
Console.WriteLine($"число {a} в степени {b} это: {result}");
*/

/*
// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDig(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = (number - number % 10) / 10;
    }
    return sum;
}
Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = SumOfDig(a);
Console.WriteLine($"сумма цифр в числе {a} это {result}");
*/

/*
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CrArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CrArray(a);
ShowArray(myArray);
*/
