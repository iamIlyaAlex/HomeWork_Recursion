using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine()!);

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine()!);

        PrintNumbersInRange(m, n);

        Console.ReadLine();
    }

    static void PrintNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbersInRange(m + 1, n);
        }
    }
}