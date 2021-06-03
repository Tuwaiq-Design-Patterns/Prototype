using System;

namespace Prototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person) this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person) this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);
            return clone;
        }

        public void Print()
        {
            Console.WriteLine($"age: {Age} BirthDate: {BirthDate} name: {Name} Id: {IdInfo.IdNumber}");
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
            Person person1 = new()
            {
                Age = 26,
                BirthDate = new DateTime(1995, 2, 16),
                IdInfo = new IdInfo(2203934),
                Name = "Ahmed"
            };
            
            Person person2 = person1.ShallowCopy();
            Person person3 = person1.DeepCopy();

            person2.Name = "Khaled";
            person2.IdInfo.IdNumber = 255;
            
            person3.Name = "Abdulaziz";
            person3.IdInfo.IdNumber = 661;
            
            person1.Print();
            person2.Print();
            person3.Print();
        }
    }
}