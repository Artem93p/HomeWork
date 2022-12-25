// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int number2 = Math.Abs(number);

if ((number2 < 10000) || (number2 > 99999))
{
    Console.WriteLine("Число не пятизначное");
}
else if ((number2 % 10 == number2 / 10000) && (number2 / 10 % 10 == number2 / 1000 % 10))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
