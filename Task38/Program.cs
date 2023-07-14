// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = CreateArrayRndDouble(8, 1, 99);
Console.Write("[");
PrintArrayDouble(array);
Console.WriteLine("]");
double MaxMin = Max(array) - Min(array);
Console.WriteLine($"{Max(array)} - {Min(array)} = {MaxMin}");

double[] CreateArrayRndDouble (int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max-min) + min;
    }
    return arr;
}

void PrintArrayDouble (double[] arr, string sep = ", ", int round = 2)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double num = Math.Round(arr[i], round);
        arr[i] = num;
        if (i < arr.Length-1) Console.Write($"{arr[i]}{sep}");
        else Console.Write(arr[i]);
    }
}

double Max (double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++) {if (arr[i] > max) max = arr[i];}
    max = Math.Round(max, 2);
    return max;
}

double Min (double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++) {if (arr[i] < min) min = arr[i];}
    min = Math.Round(min, 2);
    return min;
}