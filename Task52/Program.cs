/*Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


int InputInt(string consoleMessage)
{
    Console.Write($"Insert {consoleMessage}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2Lines(int[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Console.Write(arrayForPrint[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(double[] arrayForPrint)  
{
    for (int i = 0; i < arrayForPrint.Length - 1; i++)
    {
        Console.Write(arrayForPrint[i] + "; ");
    }
    Console.Write(arrayForPrint[arrayForPrint.Length-1] + ".");
    Console.WriteLine();
}

int m = InputInt("m");
int n = InputInt("n");

int[,] arrayRandomNumbers = new int[m, n];

for (int i = 0; i < arrayRandomNumbers.GetLength(0); i++)
{
    for (int j = 0; j < arrayRandomNumbers.GetLength(1); j++)
    {
        arrayRandomNumbers[i, j] = new Random().Next(0, 10);
    }
}

PrintArray2Lines(arrayRandomNumbers);
double[] arrayAverageColumn = new double[arrayRandomNumbers.GetLength(1)];

for (int i = 0; i < arrayRandomNumbers.GetLength(1); i++)
{
    for (int j = 0; j < arrayRandomNumbers.GetLength(0); j++)
    {
        arrayAverageColumn[i]+=Convert.ToDouble(arrayRandomNumbers[j,i]);
    }
    arrayAverageColumn[i]/=arrayRandomNumbers.GetLength(0);
}

PrintArray(arrayAverageColumn);
