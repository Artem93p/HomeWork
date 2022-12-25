// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("enter a number");
int number = int.Parse(Console.ReadLine());
if ((100 < number && number < 1000) || (-100 > number && number > -1000))
{
    if (number < 0)
    {
        number = ((number / 10) % 10) * -1;
        Console.WriteLine(number);
    }
    else
    {
        number = (number / 10) % 10;
        Console.WriteLine(number);
    }
}
else
{
    Console.WriteLine("Число не  трехзначное");
}