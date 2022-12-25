// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.Clear();

int Promt(string str)
{
    Console.Write(str);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int Sum(int number)
{
    int rezult = 0;
    while (number > 0)
    {
        int ost = number % 10;
        int sumOst = rezult + ost;
        number = number / 10;
        rezult = sumOst;
    }
    return rezult;
}

int number = Promt("Введите число: ");
int result = Sum(number);
Console.Write(result);
