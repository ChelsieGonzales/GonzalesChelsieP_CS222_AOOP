using System;

abstract class Employee 
{
   public abstract double CalculateSalary();
}

class FullTimeEmployee : Employee
{
    private double salary;
    
    public FullTimeEmployee(double salary)
    {
        this.salary = salary;
    }
    
    public override double CalculateSalary()
    {
        return salary;
    }
}

class PartTimeEmployee : Employee
{
    private double wage;
    private double hours;
    
    public PartTimeEmployee(double wage, double hours)
    {
        this.wage = wage;
        this.hours = hours;
    }
    
    public override double CalculateSalary()
    {
        return wage * hours;
    }
}

class EmployeePayrollSystem
{
    public static void Main()
    {
        Console.WriteLine("1. Full Time Employee.");
        Console.WriteLine("2. Part Time Employee.");
        
        Console.Write("\nSelect Employee Type: ");
        int choice = int.Parse(Console.ReadLine());
        
        switch(choice)
        {
            case 1: 
            Console.Write("\nEnter Employee name:  ");
            string fullTimeName = Console.ReadLine();
            
            Console.Write("Enter Monthly Salary:  ");
            double salary = double.Parse(Console.ReadLine());
            
            FullTimeEmployee fullTime = new FullTimeEmployee(salary);
            Console.WriteLine($"{fullTimeName}'s Salary: {fullTime.CalculateSalary()}");
            break;
            
            case 2:
            Console.Write("\nEnter Employee name:  ");
            string partTimeName = Console.ReadLine();
            
            Console.Write("Enter Hourly Wage:  ");
            double wage = double.Parse(Console.ReadLine());
            
            Console.Write("Enter Hours Work:  ");
            double hours = double.Parse(Console.ReadLine());
            
            PartTimeEmployee partTime = new PartTimeEmployee(wage, hours);
            Console.WriteLine($"{partTimeName}'s Salary: {partTime.CalculateSalary()}");
            break;
            
            default:
            Console.WriteLine("Invalid.");
            break;
        }
    }
}
