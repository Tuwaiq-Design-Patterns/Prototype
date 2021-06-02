using System;

namespace PrototypeDrill
{
    class Program
    {
        static void Main()
        {
            Student s1 = new("Mansour",23,new(3343));
            Student s2 = s1.ShallowCopy();
            Student s3 = s1.DeepCopy(); 
            
            Console.WriteLine(s2.studentID.id);
            Console.WriteLine(s2.Name);
            s2.studentID.id = 99;
            s2.Name = "Moosh"; 
            Console.WriteLine(s1.studentID.id);
            Console.WriteLine(s1.Name);
            
           // now s1 99 
            Console.WriteLine("------------");
            Console.WriteLine(s2.studentID.id);
            s2.studentID.id = 99; 
            Console.WriteLine(s1.studentID.id);
            

        }
    }



    class Student
    {
        public string Name;
        public int age;
        public InfoID studentID;

        public Student(string Name,int age , InfoID ss)
        {
            this.studentID = ss; 
            this.Name = Name;
            this.age = age; 
            
        }
        public Student ShallowCopy()
        {
            return (Student) this.MemberwiseClone(); 
        }


        public Student DeepCopy()
        {
            Student other = (Student) this.MemberwiseClone();
            other.studentID = new InfoID(studentID.id);
            other.Name = String.Copy(Name);
            return other;
        }
    }

    class InfoID
    {
        public int id;

        public InfoID(int id)
        {
            this.id = id;
        }
    }
}