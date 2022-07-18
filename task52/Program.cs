// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


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
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + " | ");
            else Console.Write(arr[i, j]);
        }
        Console.WriteLine();
    }

    Console.WriteLine("Среднее арифметическое элементов в каждом столбце");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        sum = Math.Round(sum / arr.GetLength(0), 1);
        Console.WriteLine($"{sum}");
        
    }
    Console.ReadLine();
}

int[,] arrayResult = CreateArray(3, 4, 1, 5);
PrintArray(arrayResult);