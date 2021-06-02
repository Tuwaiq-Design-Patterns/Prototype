using System;

namespace designpattren_2
{
    public class employee
    {
        public string name;
        public int age;
        public info depId;
        public employee(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.depId = new info(id);
        }
        public object Shallowcopy()
        {
            return (employee)this.MemberwiseClone();
        }
        public employee DeepCopy()
        {
            employee other = (employee)this.MemberwiseClone();
            employee s1 = new employee(this.name, this.age, depId.id);
            return s1;
        }
    }
    public class info
    {
        public int id;
        public info(int id)
        {
            this.id = id;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            employee employee1 = new employee("Amal", 25, 501);
            employee employee2 = (employee)employee1.Shallowcopy();
            employee2.depId.id = 3;
            Console.WriteLine(employee2.depId.id);
            Console.WriteLine(employee1.depId.id);
            employee employee3 = new employee("Ahmed", 35, 556);
            Console.WriteLine(employee3.depId.id);
            employee employee4 = (employee)employee1.DeepCopy();
            employee4.depId.id = 6;
            Console.WriteLine(employee4.depId.id);
            Console.WriteLine(employee1.depId.id);
        }
    }
}

