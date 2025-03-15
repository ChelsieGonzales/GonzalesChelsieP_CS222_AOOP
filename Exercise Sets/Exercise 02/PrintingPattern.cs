using System;

class PrintingPattern
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int size = 2 * n - 1;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                int minDist = Math.Min(Math.Min(i, j), Math.Min(size - i - 1, size - j - 1));
                Console.Write((n - minDist) + " ");
            }
            Console.WriteLine();
        }
    }
}
