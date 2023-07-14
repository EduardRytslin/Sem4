// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = CreateArrayRndInt(10, 100, 999);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
int nbr = EveNbrs(array);
Console.WriteLine($"Количество чётных чисел в данном массиве — {nbr}");


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

int EveNbrs (int[] arr)
{
    int N = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) N++;
    }
    return N;
}