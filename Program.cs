// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


static void NaturalWrite(int m, int n)
{
    m += 1;
    if (m < n)
    {
        Console.WriteLine(m);
        NaturalWrite(m, n);
    }
}

// Console.Write("Input Low limit: ");
// int m = System.Convert.ToInt32(Console.ReadLine());

// Console.Write("Input Upper limit: ");
// int n = System.Convert.ToInt32(Console.ReadLine());

// NaturalWrite(m, n);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

static int Akkerman(int m, int n)
{

    while (m != 0)
    {
        if (n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            n = Akkerman(m, n - 1);
            m -= 1;
        }

    }
    return n += 1;
}

Console.Write("Input Low limit: ");
int m = System.Convert.ToInt32(Console.ReadLine());

Console.Write("Input Upper limit: ");
int n = System.Convert.ToInt32(Console.ReadLine());

Console.Write(Akkerman(m, n));