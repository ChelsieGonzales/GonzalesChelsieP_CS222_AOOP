using System;
class InterestCalculator 
{
  static void Main() 
  {
    Console.Write("Enter principal amount: ");
    int principalAmount = int.Parse(Console.ReadLine());
    
    Console.Write("Enter rate of interest: ");
    int interest = int.Parse(Console.ReadLine());
    
    Console.Write("Enter time in years: ");
    int time = int.Parse(Console.ReadLine());
    
    double simpleInterest = (principalAmount*interest*time)/100;
    
    Console.WriteLine("Simple Interest: " + simpleInterest);
  }
}
