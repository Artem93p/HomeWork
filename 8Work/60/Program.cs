// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void ShowArray (int[,,] array )
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int q = 0; q < array.GetLength(2); q++)
            {
                Console.Write($"{array[i,j,q]}({i}{j}{q}) ");
            }
        }
        Console.WriteLine();
    }
}

int [,,] CreateRandomArray (int m, int n,int k, int leftRange, int rightRange)
{
    int [,,] array = new int[m,n,k]; // создали пустой массив

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int q = 0; q < array.GetLength(1); q++)
            {
            array[i,j,q] = new Random().Next(leftRange,rightRange);
            }
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

int m = EnterNumber ("Введите 1 число : ");
int n = EnterNumber ("Введите 2 число : ");
int k = EnterNumber ("Введите 3 число : ");

int[,,] matrix = CreateRandomArray (m,n,k,10,99);
ShowArray(matrix);
