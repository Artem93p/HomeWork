// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка;

void MinSumRows (int[,] array )
{
    int[] arraySum = new int[array.GetLength(0)]; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
                arraySum[i] += array[i, j];
        }
    System.Console.WriteLine($"Сумма в {i+1} строке = {arraySum[i]}");
    }
    int temp = arraySum[0];
    int rowMinArray = 1;
    for (int i = 1; i < arraySum.Length; i++)
    {
        if (temp > arraySum[i])
        {
            temp = arraySum[i];
            rowMinArray = i + 1;
        }
    }
    System.Console.WriteLine($"Наименьшая сумма элементов в строке № {rowMinArray}");
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
System.Console.WriteLine();
MinSumRows(matrix);