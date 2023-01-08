// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void NumberInOne(int number)
{
    if (0 < number)
    {
        System.Console.Write(number + " ");
        NumberInOne(number - 1);
    }
}

int EnterNumber(string message)
{
    System.Console.Write(message);
    int number = int.Parse(System.Console.ReadLine());
    return number;
}

int number = EnterNumber ("Введите число N : ");
NumberInOne(number);
