/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

string InputStr(string consoleMessage)
{
    Console.Write($"Insert {consoleMessage}: ");
    return Console.ReadLine();
}

int InputInt(string consoleMessage)
{
    Console.Write($"Insert {consoleMessage}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2Lines(int[,] arrayForPrint)  //печать массива
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

int m = InputInt("m");
int n = InputInt("n");

int[,] arrayRandomNumbers = new int[m, n];

for (int i = 0; i < arrayRandomNumbers.GetLength(0); i++)
{
    for (int j = 0; j < arrayRandomNumbers.GetLength(1); j++)
    {
        arrayRandomNumbers[i, j] = new Random().Next(0, 100);
    }
}

PrintArray2Lines(arrayRandomNumbers);

while (true)                                                                 // цикл, пока пользователь не введет существующую позицию
{
    string elementPosition = InputStr("position of element");

    if (elementPosition.Length == 2)
    {
        int rowFromUser = Convert.ToInt32(string.Empty + elementPosition[0]);     // string.Empty - чтобы был string, а не char
        int columnFromUser = Convert.ToInt32(string.Empty + elementPosition[1]);
        if (rowFromUser < arrayRandomNumbers.GetLength(0)
            && columnFromUser < arrayRandomNumbers.GetLength(1))
        {
            Console.WriteLine(arrayRandomNumbers[rowFromUser, columnFromUser]);
            break;
        }
        else
        {
            Console.WriteLine("No element for this position");
        }
    }
    else
    {
        Console.WriteLine("Not correct position");
    }
}
