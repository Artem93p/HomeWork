// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void ShowArray (double[,] array )
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

double [,] CreateRandomArray (int rows, int columns, int leftRange, int rigthRange)
{
    Random rand = new Random();
    double [,] array = new double[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().Next(leftRange, rigthRange + 1) + new Random().NextDouble(), 1);
        }
    }
    return array;
}

int EnterNumber (string number)
{
    System.Console.WriteLine(number);
    int numb = int.Parse(Console.ReadLine());
    return numb;
}


int n = EnterNumber ("Введите число n : ");
int m = EnterNumber ("Введите число m : ");

double [,] matrix = CreateRandomArray (n , m , -10 , 10);

ShowArray(matrix);
