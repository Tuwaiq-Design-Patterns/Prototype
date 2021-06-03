using System;

namespace Employee
{

    public class DeptID
    {
        public int ID;

        public DeptID(int id)
        {
            this.ID = id;
        }
    }

    public class Employee
    {
        public string name;
        public int age;
        public DeptID DeptID;

        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }

        public Employee DeepCopy()
        {
            Employee otherEmp = (Employee)this.MemberwiseClone();
            otherEmp.DeptID = new DeptID(DeptID.ID);
            otherEmp.name = String.Copy(name);

            return otherEmp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.age = 42;
            e1.name = "Sam";
            e1.DeptID = new DeptID(6565);
            Employee e2 = e1.ShallowCopy();

            e1.DeptID.ID = 65;
            DisplayValues(e1);
            Console.WriteLine("-------");

            DisplayValues(e2);

            Console.WriteLine("-------");
            
            e1.DeptID.ID = 6;
            Employee e3 = e1.DeepCopy();
            DisplayValues(e3);

        }

        public static void DisplayValues(Employee e)
        {
            Console.WriteLine(" Name: {0:s}, Age: {1:d}", e.name, e.age);
            Console.WriteLine(" Value: {0:d}", e.DeptID.ID);
        }
    }
}
