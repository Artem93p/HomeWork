// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

int Promt(string str)
{
    Console.Write(str);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int Exponentiation(int A, int B)
{
    int A1 = A;
    for (int i = 1; i < B; i++)
    {
        int result = A1 * A;
        A1 = result;
    }
    return A1;
}

int A = Promt("Введите число А: ");
int B = Promt("Введите число B: ");

int result = Exponentiation(A, B);
Console.WriteLine(result);