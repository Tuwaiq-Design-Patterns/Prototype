using System;

namespace RefactoringGuru.DesignPatterns.Prototype.Conceptual
{
    public class Person
    {
        public int Age;
        public DateTime DateOfBirth;
        public string Name;
        public IdInfo ID;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.ID = new IdInfo(ID.IdNumber);
            clone.Name = String.Copy(Name);
            return clone;
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Age = 42;
            person1.DateOfBirth = Convert.ToDateTime("1993-01-01");
            person1.Name = "Jack Daniels";
            person1.ID = new IdInfo(666);

            Person person2 = person1.ShallowCopy();
          
            Person person3 = person1.DeepCopy();

            
            Console.WriteLine("Original values of person1, person2 and perosn3:");
            Console.WriteLine("   person1 instance values: ");
            DisplayValues(person1);
            Console.WriteLine("   person2 instance values:");
            DisplayValues(person2);
            Console.WriteLine("   person3 instance values:");
            DisplayValues(person3);

            
            person1.Age = 32;
            person1.DateOfBirth = Convert.ToDateTime("1900-01-01");
            person1.Name = "Frank";
            person1.ID.IdNumber = 7878;
            Console.WriteLine("\nValues of person1, person2 and person3 after changes to person1:");
            Console.WriteLine("   person1 instance values: ");
            DisplayValues(person1);
            Console.WriteLine("   person2 instance values (reference values have changed):");
            DisplayValues(person2);
            Console.WriteLine("   person3 instance values (everything was kept the same):");
            DisplayValues(person3);
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                p.Name, p.Age, p.DateOfBirth);
            Console.WriteLine("      ID#: {0:d}", p.ID.IdNumber);
        }
    }
}
