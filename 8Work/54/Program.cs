// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Sort (int[,] array )
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] > array[i, j - 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j - 1];
                    array[i, j - 1] = temp;
                }
            }
        }
    }
    System.Console.WriteLine();
}

void ShowArray (int[,] array )
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] CreateRandomArray (int rows, int columns, int leftRange, int rightRange)
{
    int [,] array = new int[rows,columns]; // создали пустой массив

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(leftRange,rightRange);
        }
    }
    return array;
}

int EnterNumber(string message)
{
    System.Console.Write(message);
    int number = int.Parse(System.Console.ReadLine());
    return number;
}

int m = EnterNumber ("Введите число строк : ");
int n = EnterNumber ("Введите число столбцов : ");

int[,] matrix = CreateRandomArray (m,n,0,10);
ShowArray(matrix);
Sort(matrix);
ShowArray(matrix);