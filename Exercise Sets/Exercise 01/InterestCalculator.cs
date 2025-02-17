using System;
class InterestCalculator 
{
  static void Main() 
  {
    Console.Write("Enter principal amount: ");
    double principalAmount = double .Parse(Console.ReadLine());
    
    Console.Write("Enter rate of interest: ");
    double interest = double.Parse(Console.ReadLine());
    
    Console.Write("Enter time in years: ");
    int time = int.Parse(Console.ReadLine());
    
    double simpleInterest = (principalAmount*interest*time)/100;
    
    Console.WriteLine("Simple Interest: " + simpleInterest);
  }
}
