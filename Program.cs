// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


static void NaturalWrite(int m, int n)
{
    m+=1;
    if (m < n )
    {
        Console.WriteLine(m);
        NaturalWrite (m, n);
    }
}

Console.Write("Input Low limit: ");
int m = System.Convert.ToInt32(Console.ReadLine());

Console.Write("Input Upper limit: ");
int n = System.Convert.ToInt32(Console.ReadLine());

NaturalWrite(m, n);
