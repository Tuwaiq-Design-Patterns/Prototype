using System;

public class Info
{
    public int IdNumber;

    public Info(int IdNumber)
    {
        this.IdNumber = IdNumber;
    }
}

public class Employee
{
    public int Age;
    public string Name;
    public Info IdInfo;

    public Employee(int Age, string Name, int IdNumber)
    {
        this.Age = Age;
        this.Name = Name;
        this.IdInfo = new Info(IdNumber);
    }

    public Employee ShallowCopy()
    {
        return (Employee)this.MemberwiseClone();
    }

    public Employee DeepCopy()
    {
        Employee Emp = (Employee)this.MemberwiseClone();
        Emp.IdInfo = new Info(IdInfo.IdNumber);
        Emp.Name = String.Copy(Name);
        return Emp;
    }
}

public class Example
{
    public static void Main()
    {
        // Create an instance of Employee and assign values to its fields.
        Employee e1 = new Employee(24, "Albandry",1);
      

        // Perform a shallow copy 
        Employee e2 = (Employee)e1.ShallowCopy();
        e2.IdInfo.IdNumber = 4;

        Console.WriteLine(e2.IdInfo.IdNumber);
        Console.WriteLine(e1.IdInfo.IdNumber);

        Employee e3 = new Employee(22, "Sami", 3);
        Employee e4 = (Employee)e1.DeepCopy();

        Console.WriteLine(e3.IdInfo.IdNumber);
        e4.IdInfo.IdNumber = 6;
        Console.WriteLine(e4.IdInfo.IdNumber);





    }

 
}
