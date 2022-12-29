// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rows = EnterNumber ("Введите количество элементов в строке ");
int columns = EnterNumber ("Введите количество элементов в столбце ");

int positionRows = EnterNumber ("Введите позицию числа строке ");
int positionColumns = EnterNumber ("Введите позицию числа столбце ");

void SearchPosition(int positionRows, int positionColumns, int[,] array)
{
    if ( array.GetLength(0) <= positionRows ||  array.GetLength(1) <= positionColumns)
    {
        
        System.Console.WriteLine(" Введенной позиции нет в массиве");
    }
    else
    {
        int countI = 0;
        int countJ = 0;
        for (int i = 0; i < array.GetLength(0) +1; i++)
        {
            for (int j = 0; j < array.GetLength(1)+ 1; j++)
            {
                if (i == positionRows && j == positionColumns)
                {
                    System.Console.WriteLine($" позиции {positionRows},{positionColumns} находится число {array[positionRows, positionColumns]}");
                }
                countJ++;
            }
            countI++;
        }
    }
    
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
    int [,] array = new int [rows,columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(leftRange,rightRange);
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


int [,] matrix = CreateRandomArray (rows , columns , 0 , 10);

ShowArray(matrix);
SearchPosition (positionRows,positionColumns, matrix);