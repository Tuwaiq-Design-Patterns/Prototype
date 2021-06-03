using System;

namespace ShallowCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee emp = new Employee();
            emp.empId = 42;
            emp.empName = "FAS";
            emp.depId = new Department(6565);

            Employee emp2 = emp.ShallowCopy();


            Console.WriteLine("Original values of p1 and p2:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(emp);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(emp2);

            emp.empId = 32;
            emp.empName= "Frank";
            emp.depId.departmentId = 7878;
            Console.WriteLine("\nValues of p1 and p2 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(emp);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(emp2);

            Employee emp3 = emp.DeepCopy();

            emp.empName = "Omar";
            emp.empId = 33;
            emp.depId.departmentId = 8877;
            Console.WriteLine("\nValues of p1 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(emp);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(emp3);

        }
        public static void DisplayValues(Employee p)
            {
                Console.WriteLine("      Name: {0:s}, Age: {1:d}", p.empName, p.empId);
                Console.WriteLine("      Value: {0:d}", p.depId.departmentId);
            }
    }

    class Employee
    {
        public int empId;
        public string empName;
        public Department depId;

        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }
        public Employee DeepCopy()
        {
            Employee other = (Employee)this.MemberwiseClone();
            other.depId = new Department(depId.departmentId);
            other.empName = String.Copy(empName);
            return other;
        }
    }
    class Department
    {
        public int departmentId;
        public Department(int id)
        {
            this.departmentId = id;
        }

    }
}
