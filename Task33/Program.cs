// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// Пример:
// 4; массив [6,7,19,345,3] —> нет
// 3; массив [6,7,19,345,3] —> да

int[] CreateArrayRndInt(int size, int min, int max)
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

bool FindNumb (int[] arr, int numb)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == numb) return true;
    }
    return false;
}

Console.WriteLine("Введите целое число для поиска");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();

bool result = FindNumb(array, num);
Console.WriteLine(result? "Присутствует" : "Отсутствует");