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
        Console.Write('\"' + PrintNumbers(M, N) + '\"');
    }

    static string PrintNumbers(int start, int end)
    {
        string numbers = start.ToString();

        if (start != end)
        {
            numbers += ", " + PrintNumbers(start + 1, end);
        }

        return numbers;
    }
}