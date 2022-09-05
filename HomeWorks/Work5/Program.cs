/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);
    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n);
ShowArray(myArray);
int count = CountEven(myArray);
Console.WriteLine($"Количество чётных чисел в массиве: {count}");
*/

/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int SumOddPositionElements(int[] array)
{
    int sum = 0;
    
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
   return sum;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
int result = SumOddPositionElements(myArray);
Console.WriteLine($"Sum of the array elements in odd positions is {result}");
*/

/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Делала как в задании с вещественными числами. С целыми было бы проще: изменить все "double" на "int" и как обычно сгенерировать массив из целых чисел.
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
double [] newArray = new double[size];
for (int i = 0; i < size; i++)
    newArray[i] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) + new Random().NextDouble(); 
    return newArray;
}
void ShowArray(double[] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
    Console.WriteLine();
}
double SumMinMaxElements(double[] array)
{
    double min = 0;
    double max = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
   return min + max;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
double result = SumMinMaxElements(myArray);
Console.WriteLine($"Sum of the min and max array elements is {result}");
*/