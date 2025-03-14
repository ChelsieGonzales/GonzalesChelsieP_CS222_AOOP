using System;

class FinalTotal
{
    static void Main()
    {
        int total = 10;
        
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        
        if(integer>0)
        {
            if(integer%2 == 0)
            {
                Console.WriteLine(Math.Pow(integer, 2) + total);
            }
            else
            {
                Console.WriteLine(Math.Pow(integer, 3) + total);
            }
        }
        else if(integer<0)
        {
            Console.Write("Enter another integer: ");
            int anotherInt = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Math.Pow(integer, anotherInt) + total);
        }
        else
        {
           Console.WriteLine("Nothing Happened.");
        }
    }
}

