using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype
{

    [Serializable()]
    class IdInfo
    {
        public int id;
        public IdInfo(int id)
        {
            this.id = id;
        }
    }

    class Student
    {
        public string Name;
        public int Age;
        public IdInfo id;

        public Student(string name, int age, int id)
        {
            this.Name = name;
            this.Age = age;
            this.id = new IdInfo(id);
        }

        public Student ShallowCopy()
        {
            return (Student) this.MemberwiseClone();
        }

        public Student DeepCopy()
        {
            Student s = (Student) this.MemberwiseClone();
            s.id = new IdInfo(this.id.id);
            return s;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student("Maryam", 23, 567);
            Student scopy = s.ShallowCopy();

            Console.WriteLine($"original: {s.Name}, {s.Age}, {s.id.id}");
            Console.WriteLine($"copy: {scopy.Name}, {scopy.Age}, {scopy.id.id}");

            s.id.id = 999;
            Console.WriteLine("after update");
            Console.WriteLine($"original: {s.Name}, {s.Age}, {s.id.id}");
            Console.WriteLine($"copy: {scopy.Name}, {scopy.Age}, {scopy.id.id}");

            Student s2 = new Student("bbb", 26, 123);
            Student s2copy = s2.DeepCopy();

            Console.WriteLine($"original: {s2.Name}, {s2.Age}, {s2.id.id}");
            Console.WriteLine($"copy: {s2copy.Name}, {s2copy.Age}, {s2copy.id.id}");
            s2.id.id = 111;
            s2.Name = "aaupdated";
            Console.WriteLine("after update");
            Console.WriteLine($"original: {s2.Name}, {s2.Age}, {s2.id.id}");
            Console.WriteLine($"copy: {s2copy.Name}, {s2copy.Age}, {s2copy.id.id}");
        }
    }
}