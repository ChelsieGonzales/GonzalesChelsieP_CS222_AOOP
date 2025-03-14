using System;
class DigitPProduct

{
    static void Main()
    {
        Console.Write("Enter n: ");
        int num = int.Parse(Console.ReadLine());
        
        int digitProduct = 1;
        bool hasNonzeroDigit = false;
        
        while (num > 0)
        {
            int digit = num%10;
            
            if(digit!=0)
            {
                digitProduct*= digit;
                hasNonzeroDigit = true;
            }
            
            num/=10;
        }
        
        if(hasNonzeroDigit)
        {
            Console.Write($"Digit Product: {digitProduct}");
        }
        else
        {
            Console.WriteLine("No non-zero digits to multiply.");
        }
    }
}
