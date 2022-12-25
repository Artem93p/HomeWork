// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной");
}
else if (0 < number && number < 6)
{
    Console.WriteLine("Рабочий день");
}
else
{
    Console.WriteLine("В неделе 7 дней!");
}