using System;

class DimensionsOfASphere
{
    static double CalculateArea(double r)
    {
        int area = 4*Math.PI*Math.Pow(r,2);
        return area;
    }
    
    static double CalculateVolume(double r);
    {
        double volume = (4/3)*Math.PI*Math.Pow(r, 3);
        return volume;
    }
    
    static void Main()
    {
        Console.Write("Enter the diameter: ");
        int diameter = int.Parse(Console.ReadLine());
        
        double radius = diameter/2.0;
        
        double area = CalculateArea(radius);
        double volume = CalculateVolume(radius);
        
        Console.WriteLine($"Surface Area: {area:F2}");
        Console.WriteLine($"Volume: {volume, F2}");
    }
}
