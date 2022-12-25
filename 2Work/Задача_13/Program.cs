// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.WriteLine("enter a number");
int number = int.Parse(Console.ReadLine());
if ((number > 99) || (number < -99))
{
    while (number > 1000)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}