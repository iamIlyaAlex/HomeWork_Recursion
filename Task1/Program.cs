using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine()!);

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Натуральные числа от M до N:");
        Console.Write("\"");
        PrintNumbers(M, N);
        Console.Write("\"");
    }

    static void PrintNumbers(int M, int N)
    {
        if (M <= N)
        {
            Console.Write($"{M}");

            if (M != N)
                Console.Write(", ");

            PrintNumbers(M + 1, N);
        }
    }
}