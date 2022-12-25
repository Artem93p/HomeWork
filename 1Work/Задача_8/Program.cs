/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/* Console.Clear();
Console.WriteLine ("Введите число");
int number= int.Parse(Console.ReadLine());
int i = 1;
while (i <= number)
{
    if (i % 2 == 0)
    {
        Console.Write ($"{i},");
    }
    i++;
}
*/
//Вариант без остатка от деления ( уменьшает количество итераций)
Console.Clear();
Console.WriteLine ("Введите число");
int number= int.Parse(Console.ReadLine());
int i = 0;
while (i <= number)
{
     Console.Write ($"{i},");
     i = i +2;
}

