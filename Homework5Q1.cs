using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two integers:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int largest = a > b ? a : b;
        Console.WriteLine("The largest integer is: " + largest);
    }
}
