// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


double[] Arithmetic(int[,] array)
{
    double[] arrayArifmetic = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            arrayArifmetic[j] += array[i, j];
        }
        arrayArifmetic[j] /= (double)array.GetLength(0);
        arrayArifmetic[j] = Math.Round(arrayArifmetic[j],1);
    }
    return arrayArifmetic;
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
    int [,] array = new int[rows,columns];

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


int m = EnterNumber ("Введите число m : ");
int n = EnterNumber ("Введите число n : ");


int[,] matrix = CreateRandomArray (m,n,0,10);
ShowArray(matrix);

double[] arithmet = Arithmetic(matrix);

System.Console.WriteLine($"Среднее арифметическое значение столбцов {'[' + string.Join("; ", arithmet) + ']'}"); 




