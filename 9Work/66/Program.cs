// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumNumbers (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine(sum); 
        return;
    }
    sum = sum + (m++);
    SumNumbers(m, n, sum);
}

int EnterNumber(string message)
{
    System.Console.Write(message);
    int number = int.Parse(System.Console.ReadLine());
    return number;
}

int m = EnterNumber ("Введите число M : ");
int n = EnterNumber ("Введите число N : ");
SumNumbers(m, n, 0);