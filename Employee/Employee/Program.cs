using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ShallowCopy :");
            Employee e = new Employee("Ahmed",22,new Department(1,"IT"));

            Employee e1 = e.ShallowCopy();
            e1.department.SetNameDepartment("ART");
            Console.WriteLine(e.department.getNameDepartment());
        }
    }
}
