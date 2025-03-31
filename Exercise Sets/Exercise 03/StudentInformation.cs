using System;

class Student
{
    private string name;
    private int grade;

    public void SetName(string studentName)
    {
        name = studentName;
    }

    public string GetName()
    {
        return name;
    }

    public void SetGrade(int studentGrade)
    {
        if (studentGrade >= 0 && studentGrade <= 100)
        {
            grade = studentGrade;
        }
        else
        {
            Console.WriteLine("Invalid grade! Setting to 0.");
            grade = 0;
        }
    }

    public int GetGrade()
    {
        return grade;
    }
}

class StudentInformation
{
    static void Main()
    {
        Student student = new Student();

        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        student.SetName(name);

        Console.Write("Enter student grade: ");
        int grade = int.Parse(Console.ReadLine());
        student.SetGrade(grade);

        Console.WriteLine("\nStudent Name: " + student.GetName());
        Console.WriteLine("Student Grade: " + student.GetGrade());
    }
}
