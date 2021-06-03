using System;

namespace Protoyype
{
    class Student
    {
        public int id;

        public Student(int id)
        {
            this.id = id;

        }

    }
    class Person
    {
        public string name;
        public string hobby;
        public Student id;
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
        public Person DeepCopy()
        {
            Person ex = (Person)this.MemberwiseClone();
            ex.id = new Student(id.id);

            return ex;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.name = "p1";
            p1.hobby = "Ball";
            p1.id = new Student(13);

            Person p2 = p1.ShallowCopy();

            p2.name = "p2";


            Person p3 = p1.DeepCopy();

            p1.id.id = 13;
            p3.id.id = 10;

            p3.name = "p3";

            Console.WriteLine(p1.name);
            Console.WriteLine(p1.id.id);

            Console.WriteLine(p3.name);
            Console.WriteLine(p3.id.id);

        }
    }
}