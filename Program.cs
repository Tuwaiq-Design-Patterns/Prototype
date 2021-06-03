using System;

namespace week6day1
{
    class Program
    {
         public static void Main()
    {
        // Create an instance of Employee and assign values to its fields.
        Employee p1 = new Employee();
        p1.Age = 42;
        p1.Name = "Sam";
        p1.Department = new Department(6565);

        // Perform a shallow copy of p1 and assign it to p2.
        Employee p2 = p1.ShallowCopy();

        // Display values of p1, p2
        Console.WriteLine("Original values of p1 and p2:");
        Console.WriteLine("   p1 instance values: ");
        DisplayValues(p1);
        Console.WriteLine("   p2 instance values:");
        DisplayValues(p2);

        // Change the value of p1 properties and display the values of p1 and p2.
        p1.Age = 32;
        p1.Name = "Frank";
        p1.Department.departmentID = 7878;
        Console.WriteLine("\nValues of p1 and p2 after changes to p1:");
        Console.WriteLine("   p1 instance values: ");
        DisplayValues(p1);
        Console.WriteLine("   p2 instance values:");
        DisplayValues(p2);
    
        // Make a deep copy of p1 and assign it to p3.
        Employee p3 = p1.DeepCopy();
        // Change the members of the p1 class to new values to show the deep copy.
        p1.Name = "George";
        p1.Age = 39;
        p1.Department.departmentID = 8641;
        Console.WriteLine("\nValues of p1 and p3 after changes to p1:");
        Console.WriteLine("   p1 instance values: ");
        DisplayValues(p1);
        Console.WriteLine("   p3 instance values:");
        DisplayValues(p3);
    }

    public static void DisplayValues(Employee p)
    {
        Console.WriteLine("      Name: {0:s}, Age: {1:d}", p.Name, p.Age);
        Console.WriteLine("      Value: {0:d}", p.Department.departmentID);
    }
    }
}
