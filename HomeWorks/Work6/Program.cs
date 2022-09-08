/*
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} эллемент: ");
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
int CountPositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    return count;
}
Console.Write("Введите количество чисел, которое вам нужно: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(m);
ShowArray(myArray);
int result = CountPositiveNum(myArray);
Console.WriteLine($"Вы ввели {result} числа больше 0");
*/

/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void PointOfIntersection(double x1, double y1, double x2, double y2)
{
    double x = (y2 - y1) / (x1 - x2);
    double y = x1 * x + y1;
    if (x1 == x2) Console.WriteLine("Эти прямые параллельны");
    else Console.WriteLine($"Точка пересечения этих прямых имеет координаты: x={x}; y={y}");
}
Console.WriteLine("Введите значение коэффициента k1 прямой, заданной уравнением: y = k1 * x + b1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение коэффициента b1 прямой, заданной уравнением: y = k1 * x + b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение коэффициента k2 прямой, заданной уравнением: y = k2 * x + b2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение коэффициента b2 прямой, заданной уравнением: y = k2 * x + b2");
double b2 = Convert.ToDouble(Console.ReadLine());
PointOfIntersection(k1, b1, k2, b2);
*/