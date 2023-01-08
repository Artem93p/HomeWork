// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akker(int m, int n)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akker(n - 1, 1);
    else
        return Akker(n - 1, Akker(n, m - 1));
}
int EnterNumber(string message)
{
    System.Console.Write(message);
    int number = uint.Parse(System.Console.ReadLine());
    return number;
}

int m = EnterNumber ("Введите число M : ");
int n = EnterNumber ("Введите число N : ");
int result = Akker(m, n);
System.Console.WriteLine(result);