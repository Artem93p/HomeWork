// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

static int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
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

int a = EnterNumber ("Введите число строк 1 матрицы : ");
int b = EnterNumber ("Введите число столбцов 1 матрицы : ");
int c = EnterNumber ("Введите число строк 2 матрицы : ");
int d = EnterNumber ("Введите число столбцов 2 матрицы : ");

int[,] matrix1 = CreateRandomArray (a,b,0,10);
ShowArray(matrix1);
System.Console.WriteLine();


int[,] matrix2 = CreateRandomArray (c,d,0,10);
ShowArray(matrix2);

DivMatrix(matrix1,matrix2);
System.Console.WriteLine();
var q = DivMatrix(matrix1,matrix2);
ShowArray(q);