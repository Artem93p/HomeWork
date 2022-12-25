/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите 1 число");
int number1 = int.Parse (Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = int.Parse (Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"max = {number1}");
}
else
{
    Console.WriteLine($"max = {number2}");
}