using System;

namespace PrototypeDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new();

            std.Name = "ali";
            std.Age = 23;
            std.Id = new IdInfo(1);


            Student std2 = std.ShallowCopy();

            Console.WriteLine(std.Name);

            std2.Name = "Moh";

            Console.WriteLine(std.Name);
            Console.WriteLine(std2.Name);
            Console.WriteLine(std.Id.Id);
            
            std2.Id.Id = 3;
            Console.WriteLine(std.Id.Id);


            Student std3 = std.DeepCopy();


            Console.WriteLine(std.Id.Id);


            std3.Id.Id = 3;
            Console.WriteLine(std.Id.Id);
        }
    }

    class Student
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public IdInfo Id { set; get; }

        public Student ShallowCopy()
        {
            return (Student) this.MemberwiseClone();
        }

        public Student DeepCopy()
        {
            Student std = (Student) this.MemberwiseClone();
            std.Id = new IdInfo(std.Id.Id);
            std.Name = String.Copy(std.Name);
            return std;
        }
    }

    class IdInfo
    {
        public IdInfo(int Id)
        {
            this.Id = Id;
        }

        public int Id { set; get; }
    }
}