using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DP_Prototype
{
    class Student
    {
        public string Name;
        public int Age;
        public InfoId ID;
        public Student(string name, int age, InfoId id)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
        }
        public Student ShallowCopy()
        {
            return (Student) this.MemberwiseClone();
        }
        public Student DeepCopy()
        {

            Student temp = (Student) this.MemberwiseClone();
            temp.ID = new InfoId(this.ID.ID);
            return temp;
        }

    }
    class InfoId
    {
        public int ID;
        public InfoId(int id)
        {
             this.ID = id;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Cast Student to use memberwise object
            Student stu = new Student( "Ahmed", 22, new InfoId(234));
            Console.WriteLine("The student name is {0} their age is {1} and their ID is {2}.", stu.Name, stu.Age, stu.ID.ID);

            Student stu3 = stu.DeepCopy();
            stu3.ID.ID= 789;
            Console.WriteLine("The student name is {0} their age is {1} and their new ID is {2}.", stu.Name, stu.Age, stu.ID.ID);

            Student stu2 = stu.ShallowCopy();
            stu2.ID.ID = 789;
            Console.WriteLine("The student name is {0} their age is {1} and their new ID is {2}.", stu.Name, stu.Age, stu.ID.ID);

            Console.ReadKey();
        }
    }
}
