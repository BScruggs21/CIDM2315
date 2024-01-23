using System;

class Program
{
    static void Main()
    {
        double X = 2.5;
        double Y = 3.3;
        double Z = 4 * Math.Pow(X, 2) + 3 * Y;
        Console.WriteLine($"The value of Z for X = {X} and Y = {Y} is: {Z}");
    }
}
