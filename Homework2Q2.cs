using System;

class Program
{
    static void Main()
    {
        int num1 = Convert.ToInt32(Console.ReadLine(12));
        int num2 = Convert.ToInt32(Console.ReadLine(14));
        int num3 = Convert.ToInt32(Console.ReadLine(16));
        int smallest;
        if (num1 <= num2 && num1 <= num3)
        {
            smallest = num1;
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            smallest = num2;
        }
        else
        {
            smallest = num3;
        }

        Console.WriteLine($"The smallest value is: {smallest}");
    }
}
