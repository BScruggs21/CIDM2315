using System;

class Program
{
    static void Main()
    {
        Console.Write;
        char letterGrade = char.Parse(Console.ReadLine());

        double gpa;

        switch (Char.ToUpper(letterGrade))
        {
            case 'A':
                gpa = 4.0;
                break;
            case 'B':
                gpa = 3.0;
                break;
            case 'C':
                gpa = 2.0;
                break;
            case 'D':
                gpa = 1.0;
                break;
            case 'F':
                gpa = 0.0;
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                return;
        }

        Console.WriteLine($"GPA Points: {gpa}");
    }
}
