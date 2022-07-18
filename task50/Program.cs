// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите через пробел размер двухмерного массива:");
int [] size = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
Console.WriteLine("Введите через пробел координаты позиции элемента :");
int [] position = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int[,] CreateArray(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j]+ " | ");
            else Console.Write(arr[i, j]);
        }
        Console.WriteLine();
    }
}

void Posit (int[,] arr)
{
    if (position[0] < size [0] && position[1] < size[1])
    {
        Console.WriteLine($"Значение элемента: = {arr[position[0], position[1]]}");
    }
    else Console.WriteLine("Такого элемента нет");
}


int[,] arrayResult = CreateArray(size[0], size[1], 1, 10);
PrintArray(arrayResult);
Posit(arrayResult);



