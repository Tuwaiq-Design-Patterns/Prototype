using System;

namespace Prototype
{
    public class student
    {
        public string name;
        public int age;
        public InfoId id;
        public student(string name,int age,InfoId id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
        public student Copy()
        {
            return (student)this.MemberwiseClone();
        }
        public student DeepCopy()
        {
            student newStudent = (student)this.MemberwiseClone();
            newStudent.id = new InfoId(id.id);
            return newStudent;
        }
    }
    public class InfoId
    {
        public int id;
        public InfoId(int id)
        {
            this.id = id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student ahmad = new student("ahmad",30,new InfoId(122));
            
            Console.WriteLine(ahmad.name);
            Console.WriteLine(ahmad.id.id);

            student mohammad = ahmad.DeepCopy();

            mohammad.name = "mohammad";
            mohammad.id.id = 1111;
            Console.WriteLine(mohammad.name);
            Console.WriteLine(mohammad.id.id);
        }
    }
}
