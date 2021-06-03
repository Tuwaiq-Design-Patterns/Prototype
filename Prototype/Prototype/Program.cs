using System;

namespace Prototype
{
    public class info
    {
        public int infoId;
        public info(int infoId)
        {
            this.infoId = infoId;
        }
    }
    public class Employee
    {

        public string name;
        public int age;
        public info depId;
        public Employee(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.depId = new info(id);
        }
        public object Shallowcopy()
        {
            return (Employee)this.MemberwiseClone();
        }
        public Employee DeepCopy()
        {
            Employee other = (Employee)this.MemberwiseClone();
            Employee s1 = new Employee(this.name, this.age, depId.infoId);
            return s1;
        }
    }
   
    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee("Reema", 23, 13);
            Employee empCopy = (Employee)emp.Shallowcopy();
            empCopy.depId.infoId = 333;

            Console.WriteLine($"original employee: {emp.name}, {emp.age}, {emp.depId.infoId}");
            Console.WriteLine($"employee clone: {empCopy.name}, {empCopy.age},{emp.depId.infoId}");

            Employee emp4 = (Employee)emp.DeepCopy();

            Console.WriteLine($"employee deep clone before change: {emp4.name}, {emp4.age},{emp4.depId.infoId}");

            emp4.depId.infoId = 77;
            
 
            Console.WriteLine($"employee deep clone after change: {emp4.name}, {emp4.age},{emp4.depId.infoId}");
            
            
        }
    }
}
