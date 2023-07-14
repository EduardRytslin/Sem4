// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = CreateArrayRndInt(10, -99, 99);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
int sum = OddSum (array);
Console.WriteLine($"Сумма нечётных элементов — {sum}");

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
}

void PrintArray (int[] arr, string sep = ", ")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length-1) Console.Write($"{arr[i]}{sep}");
        else Console.Write(arr[i]);
    }
}

int OddSum (int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i+2)
    {
        sum += arr[i];
    }
    return sum;
}