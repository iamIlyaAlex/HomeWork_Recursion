using System;

class Program
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            if (index != arr.Length - 1)
            {
                Console.Write(", ");
            }
            Console.Write(arr[index]);
            PrintArrayReverse(arr, index - 1);
        }
    }

    static void Main(string[] args)
    {
        int[] arr = {11, 22, 13, 14, 35};
        
        Console.Write("Массив: ");
        PrintArrayReverse(arr, arr.Length - 1);
        Console.WriteLine("");
    }
}