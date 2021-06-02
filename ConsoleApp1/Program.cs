using System;

namespace ConsoleApp1
{
    class Program
    {
        class IdInfo
        {
            public int id;
        }

        class student
        {
            public string Name;
            public int Age;
            public IdInfo IdInfo;

            public student shallowcopy()
            {
                return (student)this.MemberwiseClone();
            }

            public student DeepCopy()
            {
                student other = (student)this.MemberwiseClone();
                other.IdInfo = new IdInfo() { id=IdInfo.id };
                return other;
            }
        }
        static void Main(string[] args)
        {
            student originalStudent = new student()
            {
                Name = "Ali",
                Age = 24,
                IdInfo = new IdInfo() { id = 1112 }
            };

            var ShallowedStudent = originalStudent.DeepCopy();
            ShallowedStudent.Name = "aaa";
            Console.WriteLine(ShallowedStudent.Name);
            Console.WriteLine(originalStudent.Name);



        }
    }
}
