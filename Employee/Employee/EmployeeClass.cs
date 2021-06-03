using System;
namespace Employee
{
    public class Employee
    {
        public String Name;
        public int age;
        public Department department;

        public Employee(string name, int age, Department department)
        {
            Name = name;
            this.age = age;
            this.department = department;
        }

        //public String getNameDepartment()
        //{
        //    return this.department.Name;
        //}

        public Employee()
        {

        }
        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "Name: "+ this.Name ;
        }
    }
}
