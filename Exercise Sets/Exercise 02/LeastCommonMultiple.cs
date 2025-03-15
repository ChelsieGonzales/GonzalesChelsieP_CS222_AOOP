using System;

class LeastCommonMultiple
{
    static int FindLCM(int[] arr)
    {
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }

        int lcm = max;

        while (true)
        {
            bool isLCM = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (lcm % arr[i] != 0)
                {
                    isLCM = false;
                    break;
                }
            }
            if (isLCM)
                return lcm;
            lcm++;
        }
    }

    static void Main()
    {
        Console.Write("Enter number of inputs: ");
        int input = int.Parse(Console.ReadLine());

        int[] array = new int[input];

        for (int i = 0; i < input; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int lcmResult = FindLCM(array);
        Console.WriteLine("LCM of the entered numbers: " + lcmResult);
    }
}
