using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter four integers:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        int largest = GetLargest(GetLargest(a, b), GetLargest(c, d));
        Console.WriteLine("The largest integer is: " + largest);
    }

    static int GetLargest(int a, int b)
    {
        return a > b ? a : b;
    }
}
