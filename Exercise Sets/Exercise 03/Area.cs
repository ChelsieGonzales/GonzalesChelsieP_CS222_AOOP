using System;

abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle : Shape
{
    private double radius;
    
    public Circle (double radius)
    {
        this.radius = radius;
    }
    
    public override double CalculateArea()
    {
        return Math.PI*(radius*radius);
    }
}

class Rectangle: Shape
{
    private double height; 
    private double width;
    
    public Rectangle (double height, double width)
    {
        this.height = height;
        this.width = width;
    }
    
    public override double CalculateArea()
    {
        return width * height;
    }
}

class Area
{
    static void Main()
    {
        Console.WriteLine("1. Calculate Area Of Circle.");
        Console.WriteLine("2. Calculate Area of Rectangle.");
        Console.Write("\nWhat do you want to perform: ");
        int choice = int.Parse(Console.ReadLine());
        
        switch(choice)
        {
            case 1: 
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            
            Circle circle = new Circle(radius);
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            break;
            
            case 2:
            Console.Write("Enter the height of the rectangle: ");
            double height = double.Parse(Console.ReadLine());
            
            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            
            Rectangle rectangle = new Rectangle(height, width);
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            break;
            
            default:
            Console.WriteLine("Invalid.");
            break;
        }
    }
}
