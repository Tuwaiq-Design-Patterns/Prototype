using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(){name="ha",age=23,id = new Infoid(){id = 21}};
            Student mohamed = st.deepcopy();
            st.id.id = 3;
            Console.WriteLine(mohamed.id.id);
        }
    }

    class Student
    {
        public string name;
        public int age;
        public Infoid id;

        public Student copy()
        {
            return (Student)this.MemberwiseClone();
        }

        public Student deepcopy()
        {
            Student other = (Student) this.MemberwiseClone();
            other.id = new Infoid(){id = id.id};
            other.name = String.Copy(name);
            return other;
        }
    }

    class Infoid
    {
        public int id;
    }
}