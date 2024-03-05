using System;

public class Customer
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Customer(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public void ChangeId(int newId)
    {
        Id = newId;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
    }

    public string OlderCustomerName(Customer other)
    {
        return Age > other.Age ? Name : other.Name;
    }
}

class Program
{
    static void Main()
    {
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        Console.WriteLine("Initial customer information:");
        customer1.PrintInfo();
        customer2.PrintInfo();

        customer1.ChangeId(220);
        customer2.ChangeId(221);

        Console.WriteLine("\nCustomer information after updating IDs:");
        customer1.PrintInfo();
        customer2.PrintInfo();

        Console.WriteLine("\nThe older customer is: " + customer1.OlderCustomerName(customer2));
    }
}
