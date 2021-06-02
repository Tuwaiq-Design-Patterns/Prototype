using System;

namespace Prototype
{
    class Student {

        public string Name;
        public int Age;
        public IdInfo Id;

       public Student(string name, int age, int id )
        {
            this.Name = name;
            this.Age = age;
            Id = new IdInfo(id);
        }

        public object Shallowcopy()
        {
            return (Student)this.MemberwiseClone();
        }
        public Student DeepCopy()
        {
            Student student = new Student(this.Name, this.Age,Id.Id);
            return student;
        }
    }
    class IdInfo {
        public int Id;

        public IdInfo(int id)
        {
            this.Id = id;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Sara",25,1);
            Student st2 = (Student)st.Shallowcopy();
            Student st3 = st.DeepCopy();

            st2.Name = "Amal";
            st3.Id.Id = 3;
            Console.WriteLine(st.Name);
            
            Console.WriteLine(st2.Name);

            st3.Name = "Jmoon";
            Console.WriteLine(st3.Id.Id);
            Console.WriteLine(st.Id.Id);
            Console.WriteLine(st.Name);

            Console.WriteLine(st3.Name);

        }
    }
}
