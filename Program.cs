using System;

namespace PrototypePractice
{
    class Program
    {

        public class DepID
        {
            public int id { get; set; }
        }

        public class Employee
        {
            public string name;
            public int age;
            public DepID departmentID;

            public Employee ShallowCopy()
            {
                return (Employee)this.MemberwiseClone();
            }

            //public Employee DeepCopy()
            //{
            //    Employee other = (Employee)this.MemberwiseClone();
            //    other.departmentID = new DepID() { id = departmentID.id};
            //    return other;
            //}

        }




        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.name = "ahmed";
            emp1.age = 25;
            emp1.departmentID = new DepID();

            Employee emp2 = emp1.ShallowCopy();
            emp2.name = "Mohammed";
            emp2.age = 22;
            emp2.departmentID.id = 3;

            Console.WriteLine(emp1.departmentID.id.ToString());
            Console.WriteLine(emp2.departmentID.id.ToString());
            

        }
    }
}
