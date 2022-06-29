/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int InputInt (string consoleMessage)
{
    Console.Write($"Insert {consoleMessage}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2Lines(double[,] arrayForPrint)  //печать массива
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Console.Write(arrayForPrint[i,j]+"  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int m = InputInt("m");
int n = InputInt("n");
double [,] arrayRealNumbers = new double[m,n];

for (int i = 0; i < arrayRealNumbers.GetLength(0); i++)
{
    for (int j = 0; j < arrayRealNumbers.GetLength(1); j++)
    {
        arrayRealNumbers[i,j] = Convert.ToDouble(new Random().Next(1000,10000))/1000;
    }
}

PrintArray2Lines(arrayRealNumbers);



