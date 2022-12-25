// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int Promt(string str)
{
    Console.WriteLine(str);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int N = Promt("Введите число");
for (int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3));
    if (i + 1 <= N)
    {
        Console.Write(",");
    }
}
