
using System;

namespace ConceptDesignPattren
{
    public class Student
    {
        public int Age;
        public string Name;
        public IdInfo IdInfo;

        public Student ShallowCopy()
        {
            return (Student)this.MemberwiseClone();
        }

        public Student DeepCopy()
        {
            Student deepStudent = (Student)this.MemberwiseClone();
            deepStudent.IdInfo = new IdInfo(IdInfo.IdNumber);
            deepStudent.Name = String.Copy(Name);
            return deepStudent;
        }
    }
    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }

    public class Program
    {
        public static void Main()
        {
            
            Student s1 = new Student();
            s1.Age = 23;
            s1.Name = "Taif";
            s1.IdInfo = new IdInfo(999);

            
            Student s2 = s1.ShallowCopy();

            
            Console.WriteLine("Values  after shallow Copy");
            Console.WriteLine("Student 1 :");
            PrintInfo(s1);
            Console.WriteLine("Student 2 :");
            PrintInfo(s2);

           
            s1.Age = 25;
            s1.Name = "Asma";
            s1.IdInfo.IdNumber = 888;
            Console.WriteLine("***********************************");
            Console.WriteLine("Values  after change in Student 1 :");
            Console.WriteLine("***********************************");
            Console.WriteLine("Student 1 :");
            PrintInfo(s1);
            Console.WriteLine("Student 2 :");
            PrintInfo(s2);

            
            Student s3 = s1.DeepCopy();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Values  after depp Copy");
            Console.WriteLine("Student 1 :");
            PrintInfo(s1);
            Console.WriteLine("Student 3 :");
            PrintInfo(s3);

            s1.Name = "Nora";
            s1.Age = 27;
            s1.IdInfo.IdNumber = 777;
            Console.WriteLine("***********************************");
            Console.WriteLine("Values  after change in Student 1 :");
            Console.WriteLine("***********************************");
            Console.WriteLine("Student 1 :");
            PrintInfo(s1);
            Console.WriteLine("Student 3 :");
            PrintInfo(s3);
        }

        public static void PrintInfo(Student s)
        {
            Console.WriteLine("      Name: {0}, Age: {1}", s.Name, s.Age);
            Console.WriteLine("      ID: {0}", s.IdInfo.IdNumber);
        }
    }
}

  