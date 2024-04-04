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

// Console.Write("Input Low limit: ");
// int m = System.Convert.ToInt32(Console.ReadLine());

// Console.Write("Input Upper limit: ");
// int n = System.Convert.ToInt32(Console.ReadLine());

// Console.Write(Akkerman(m, n));

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

static void ArrayReversOutput(int[] arr)
{
    int i = arr.Length;
    if (i > 0)
    {
        Console.Write("{0}\t", arr[i - 1] + " ");
        ArrayReversOutput(arr[..(i - 1)]);
    }
}


Console.Write("Input array length: ");
int n = System.Convert.ToInt32(Console.ReadLine());
int[] myArr = new int[n];
Random rand = new Random();
for (int i = 0; i < n; i += 1)
{
    myArr[i] = rand.Next(1, 99);
    Console.Write("{0}\t", myArr[i]);
}
Console.WriteLine();

ArrayReversOutput(myArr);