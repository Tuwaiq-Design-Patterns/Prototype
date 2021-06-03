using System;

namespace Week2Copy
{
    class DepartementId
    {
        public int Id { get; set; }
        public DepartementId(int id)
        {
            this.Id = id;
        }

    }

    class Employee
    {
        public string Name { get; set; }
        public int age { get; set; }
        public DepartementId id { get; set; }

        public Employee(string Name, int age, int id)
        {
            this.Name = Name;
            this.age = age;
            this.id = new DepartementId(id);
        }

        public object Shallowcopy()
        {
            return this.MemberwiseClone();
        }

        public Employee DeepCopy()
        {
            Employee emp = new Employee(this.Name, this.age, id.Id);
            return emp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Shallow copy
            Console.WriteLine("Shallow copy");
            Console.WriteLine("Before ...");
            Employee emp1 = new Employee("Adel", 24, 1);
            Employee emp2 = (Employee)emp1.Shallowcopy();
            Console.WriteLine("name: " + emp1.Name + " Age: " + emp1.age + " Id: " + emp1.id.Id);
            Console.WriteLine("name: " + emp2.Name + " Age: " + emp2.age + " Id: " + emp2.id.Id);

            Console.WriteLine("After ...");
            emp2.Name = "Turki";
            emp2.age = 27;
            emp2.id.Id = 5;
            Console.WriteLine("name: " + emp1.Name + " Age: " + emp1.age + " Id: " + emp1.id.Id);
            Console.WriteLine("name: " + emp2.Name + " Age: " + emp2.age + " Id: " + emp2.id.Id);

            //deep copy
            Console.WriteLine("\ndeep copy");
            Console.WriteLine("Before ...");
            emp1 = new Employee("Adel", 24, 1);
            emp2 = emp1.DeepCopy();
            Console.WriteLine("name: " + emp1.Name + " Age: " + emp1.age + " Id: " + emp1.id.Id);
            Console.WriteLine("name: " + emp2.Name + " Age: " + emp2.age + " Id: " + emp2.id.Id);

            Console.WriteLine("After ...");
            emp2.Name = "Turki";
            emp2.age = 27;
            emp2.id.Id = 5;
            Console.WriteLine("name: " + emp1.Name + " Age: " + emp1.age + " Id: " + emp1.id.Id);
            Console.WriteLine("name: " + emp2.Name + " Age: " + emp2.age + " Id: " + emp2.id.Id);
        }
    }
}
