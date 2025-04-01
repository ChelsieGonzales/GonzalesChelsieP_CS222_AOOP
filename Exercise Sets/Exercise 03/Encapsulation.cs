using System;

abstract class Employee
{
    public string Name { get; set; } // Encapsulated Name property

    public Employee(string name)
    {
        Name = name;
    }

    public abstract double CalculateSalary();
}

class FullTimeEmployee : Employee
{
    private double salary; // Encapsulated field

    public double Salary
    {
        get { return salary; }
        set
        {
            if (value >= 0)
                salary = value;
            else
                Console.WriteLine("Salary cannot be negative.");
        }
    }

    public FullTimeEmployee(string name, double salary) : base(name)
    {
        Salary = salary;
    }

    public override double CalculateSalary()
    {
        return Salary;
    }
}

class PartTimeEmployee : Employee
{
    private double wage;
    private double hours;

    public double Wage
    {
        get { return wage; }
        set
        {
            if (value >= 0)
                wage = value;
            else
                Console.WriteLine("Wage cannot be negative.");
        }
    }

    public double Hours
    {
        get { return hours; }
        set
        {
            if (value >= 0)
                hours = value;
            else
                Console.WriteLine("Hours cannot be negative.");
        }
    }

    public PartTimeEmployee(string name, double wage, double hours) : base(name)
    {
        Wage = wage;
        Hours = hours;
    }

    public override double CalculateSalary()
    {
        return Wage * Hours;
    }
}

class Encapsulation
{
    public static void Main()
    {
        Console.WriteLine("1. Full Time Employee.");
        Console.WriteLine("2. Part Time Employee.");

        Console.Write("\nSelect Employee Type: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("\nEnter Employee Name: ");
                string fullTimeName = Console.ReadLine();

                Console.Write("Enter Monthly Salary: ");
                double salary = double.Parse(Console.ReadLine());

                FullTimeEmployee fullTime = new FullTimeEmployee(fullTimeName, salary);
                Console.WriteLine($"{fullTime.Name}'s Salary: {fullTime.CalculateSalary()}");
                break;

            case 2:
                Console.Write("\nEnter Employee Name: ");
                string partTimeName = Console.ReadLine();

                Console.Write("Enter Hourly Wage: ");
                double wage = double.Parse(Console.ReadLine());

                Console.Write("Enter Hours Worked: ");
                double hours = double.Parse(Console.ReadLine());

                PartTimeEmployee partTime = new PartTimeEmployee(partTimeName, wage, hours);
                Console.WriteLine($"{partTime.Name}'s Salary: {partTime.CalculateSalary()}");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
