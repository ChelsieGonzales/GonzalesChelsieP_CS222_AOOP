using System;

class OneD
{
    static void Main()
    {
        Console.Write("Enter the number of data points: ");
        int data = int.Parse(Console.ReadLine());
        
        int [] array = new int [data];
        
        for(int i = 0; i < data; i++)
        {
            Console.Write($"Enter value {i + 1}: ");
            array [i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("\nOriginal Array: [" + string.Join(", ", array) + "]");
        
        Console.WriteLine($"\nMaximum Value: {MaxValue(array)}");
        
        Console.WriteLine($"\nMinimum Value: {MinValue(array)}");
        
        Console.WriteLine($"\nAverage: {Average(array)}");
    }
    
    public static int MaxValue(int [] array) 
    {
        int max = array[0];
        
        foreach(int num in array)
        {
            if(num > max)
            {
                max = num;
            }
        }
        return max;
    }
    
    public static int MinValue(int [] array)
    {
        int min = array[0];
        
        foreach (int value in array)
        {
            if(value < min)
            {
                min = value;
            }
        }
        return min;
    }
    
    public static double Average(int [] array)
    {
        double sum = 0;
        
        foreach(double elements in array)
        {
            sum += elements;
        }
        
        double average = sum/array.Length;
        
        return average;
    }
}
