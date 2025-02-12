using System;

class AlternatingChars
{
    static void Main()
    {
        Console.Write("First character: ");
        char firstChar = char.Parse(Console.ReadLine());

        Console.Write("Second character: ");
        char secondChar = char.Parse(Console.ReadLine());

        Console.Write("Enter size: ");
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("-");
            }
            if (i % 2 == 0)
                Console.WriteLine(firstChar);
            else
                Console.WriteLine(secondChar);
        }
    }
}
