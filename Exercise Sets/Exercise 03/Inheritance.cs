using System;

// Base class (Parent)
abstract class Employee
{
    public string Name { get; set; } // Inherited by child classes
    public string EmployeeID { get; set; } // Common property

    public Employee(string name, string employeeID)
    {
        Name = name;
        EmployeeID = employeeID;
    }

    // Abstract method (must be implemented by child classes)
    public abstract double CalculateSalary();

    // Common method (inherited by all employees)
    public virtual void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Name: {Name}");
    }
}

// Derived class (Child) - Full-time employee
class FullTimeEmployee : Employee
{
    private double salary;

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

    public FullTimeEmployee(string name, string employeeID, double salary)
        : base(name, employeeID)
    {
        Salary = salary;
    }

    public override double CalculateSalary()
    {
        return Salary;
    }

    // Override display method to add salary info
    public override void DisplayEmployeeInfo()
    {
        base.DisplayEmployeeInfo();
        Console.WriteLine($"Monthly Salary: {Salary}");
    }
}

// Derived class (Child) - Part-time employee
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

    public PartTimeEmployee(string name, string employeeID, double wage, double hours)
        : base(name, employeeID)
    {
        Wage = wage;
        Hours = hours;
    }

    public override double CalculateSalary()
    {
        return Wage * Hours;
    }

    // Override display method to add wage and hours info
    public override void DisplayEmployeeInfo()
    {
        base.DisplayEmployeeInfo();
        Console.WriteLine($"Hourly Wage: {Wage}, Hours Worked: {Hours}");
    }
}

// Main program
class Inheritance
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
                Console.Write("\nEnter Employee ID: ");
                string fullTimeID = Console.ReadLine();

                Console.Write("Enter Employee Name: ");
                string fullTimeName = Console.ReadLine();

                Console.Write("Enter Monthly Salary: ");
                double salary = double.Parse(Console.ReadLine());

                FullTimeEmployee fullTime = new FullTimeEmployee(fullTimeName, fullTimeID, salary);
                fullTime.DisplayEmployeeInfo();
                Console.WriteLine($"Total Salary: {fullTime.CalculateSalary()}");
                break;

            case 2:
                Console.Write("\nEnter Employee ID: ");
                string partTimeID = Console.ReadLine();

                Console.Write("Enter Employee Name: ");
                string partTimeName = Console.ReadLine();

                Console.Write("Enter Hourly Wage: ");
                double wage = double.Parse(Console.ReadLine());

                Console.Write("Enter Hours Worked: ");
                double hours = double.Parse(Console.ReadLine());

                PartTimeEmployee partTime = new PartTimeEmployee(partTimeName, partTimeID, wage, hours);
                partTime.DisplayEmployeeInfo();
                Console.WriteLine($"Total Salary: {partTime.CalculateSalary()}");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
