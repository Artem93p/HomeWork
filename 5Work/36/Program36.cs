// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int SIZE = 10;
int LEFT_RANGE = -100;
int RIGHT_RANGE = 100;

int[] array = new int[SIZE];
Random rand = new Random();

int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);

int Sum = 0;
for (int i = 0; i <= array.Length - 1; i = i+2)
{
    Sum = Sum + array[i];
}
System.Console.WriteLine("[" + string.Join(",", array) + "]");
System.Console.WriteLine(Sum);