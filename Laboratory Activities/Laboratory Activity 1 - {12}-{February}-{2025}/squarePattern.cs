using System;
class SquarePattern{
  static void Main() {
    Console.Write("Enter n: ");
    int row = int.Parse(Console.ReadLine());
    
    Console.Write("Enter y: ");
    int skipRow= int.Parse(Console.ReadLine());
    
    for(int i = 1; i <= row; i++)
    {
        if(i == skipRow)
        {
            Console.WriteLine();
            continue;
        }
        
        for(int j = 1 ; j <= row; j++)
        {
            Console.Write("* ");
            
        }
        Console.WriteLine();
    }
  }
}
