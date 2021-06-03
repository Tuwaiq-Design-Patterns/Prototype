using System;

namespace copyDesignPattren
{

    public class InfoId
    {
        public int Id;

        public InfoId(int id)
        {
            this.Id = id;
        }
    }

    public class Student
    {
        public string Name;
        public int Age;
        public InfoId InfoId;

        public Student ShallowCopy()
        {
            return (Student)this.MemberwiseClone();
        }

        public Student DeepCopy()
        {
            Student otherstudent = (Student)this.MemberwiseClone();
            otherstudent.InfoId = new InfoId(InfoId.Id);
            otherstudent.Name = String.Copy(Name);
            return otherstudent;

        }
     
        
    }

    public class Program
    {
        public static void Main()
        {

            Student student = new Student();

            student.Name = "Norah";
            student.Age = 24;
            student.InfoId = new InfoId(1234);

            Student student2 = student.ShallowCopy();

            //dispaly student1
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.InfoId.Id);

            //dispaly student2
            Console.Write("\n");
            Console.WriteLine(student2.Name);
            Console.WriteLine(student2.Age);
            Console.WriteLine(student2.InfoId.Id);
            Console.Write("\n");

            //change value of student 1
            student.Name = "Maha";
            student.Age = 26;
            student.InfoId.Id = 9876;
            Console.Write("\n");

            //dispaly student1
            Console.WriteLine(student.Name );
            Console.WriteLine(student.Age);
            Console.WriteLine(student.InfoId.Id);

            //dispaly student2
            Console.Write("\n");
            Console.WriteLine(student2.Name);
            Console.WriteLine(student2.Age);
            Console.WriteLine(student2.InfoId.Id);
            Console.Write("\n");

            // deep copy of student1 and assign it to student3
            Student student3 = student.DeepCopy();
            // Change the members of the p1 class to new values to show the deep copy.
            student.Name = "amani";
            student.Age = 34;
            student.InfoId.Id = 3535;

            //dispaly student1
            Console.Write("\n");
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.InfoId.Id);
            Console.Write("\n");

            //dispaly student3
            Console.Write("\n");
            Console.WriteLine(student3.Name);
            Console.WriteLine(student3.Age);
            Console.WriteLine(student3.InfoId.Id);
            Console.Write("\n");

         
        }

 
    }
}