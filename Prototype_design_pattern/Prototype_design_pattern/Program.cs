using System;

namespace Prototype_design_pattern
{
    class Student
    {
        public string name;
        public int age;
        public InfoId infoId;
        public Student(string name, int age, InfoId infoId)
        {
            this.name = name;
            this.age = age;
            this.infoId = infoId;
        }
        public Student clone()
        {
            return (Student) this.MemberwiseClone();
        }
        public Student deepClone()
        {
            Student s = (Student) this.MemberwiseClone();
            s.infoId = new InfoId(this.infoId.id);
            return s;
        }
    }
    class InfoId
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
            Student s1 = new Student("ahmad", 40, new InfoId(23));
            Student s2 = s1.deepClone();
            Console.WriteLine("Student 1: " + s1.name + " - " + s1.age + " - " + s1.infoId.id);
            Console.WriteLine("Student 2: " + s2.name + " - " + s2.age + " - " + s2.infoId.id);
            Console.WriteLine("=================");
            s1.infoId.id = 9999;
            Console.WriteLine("Student 1 after change: " + s1.name + " - " + s1.age + " - " + s1.infoId.id);
            Console.WriteLine("Student 2 after changing s1: " + s2.name + " - " + s2.age + " - " + s2.infoId.id);
        }
    }
}
