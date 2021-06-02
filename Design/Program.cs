using System;

namespace Design
{
    class Program
    {

        public class Employee
        {
            public int id;
            public string name;
            public int age;
            public DepartmentId deptId;

            public Employee ShallowCopy()
            {
                return (Employee)this.MemberwiseClone();
            }

            public Employee DeepCopy()
            {
                Employee other = this.ShallowCopy();
                other.deptId = new DepartmentId() { id = this.deptId.id };
                return other;
            }

        }

        public class DepartmentId
        {
            public int id;
        }

        static void Main(string[] args)
        {
            Employee first = new Employee() { id = 1, name = "Abdulmajeed", age = 23, deptId = new DepartmentId() { id = 1 } };
            Employee second = first.ShallowCopy();
            second.id = 2;
            second.name = "ahmed";
            second.age = 28;
            second.deptId.id = 2;

            Console.WriteLine("First info: " + first.id + " " + first.name + " " + first.age + " " + first.deptId.id);
            Console.WriteLine("Second info: " + second.id + " " + second.name + " " + second.age + " " + second.deptId.id);
        }
    }

    
}
