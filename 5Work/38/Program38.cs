// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int SIZE = 10;

double[] array = new double[SIZE];
Random rand = new Random();

double[] FillArray(int size)
{
    Random rand = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rand.NextDouble() * 100, 3);
    }
    return arr;
}
array = FillArray(SIZE);

double min = array[0];
double max = array[0];
for (int i = 0; i < SIZE; i++)
{
    if (min >= array[i])
    {
        min = array[i];
    }
    if (max <= array[i])
    {
        max = array[i];
    }
}
double result = max - min;

System.Console.WriteLine("[" + string.Join("; ", array) + "]");
System.Console.WriteLine("Разница между минимальным и максимальным числом массива = " + Math.Round(result, 3));