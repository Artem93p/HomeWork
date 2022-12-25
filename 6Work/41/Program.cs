// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4


Console.WriteLine("Числа через запятую");
int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse); // не совсем понял данную запись, по другому не получилось


int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

System.Console.WriteLine("Чисел больше нуля : " + count);