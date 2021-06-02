using System;

namespace PrototypeD
{ 
    //memberwiseclone
     //return object
        public class student
        {
            public string name;
            public int age;
            public info infoid;

            public student(string name, int age, int id)
            {
                this.name = name;
                this.age = age;
                this.infoid = new info(id);
            }

            public object Shallowcopy()
            {
                return (student)this.MemberwiseClone();

            }
            public student DeepCopy()
            {
                student s1 = new student(this.name, this.age, infoid.id);

                return s1;

            }

        }

        public class info
        {
            public int id;

            public info(int id)
            {
                this.id = id;
            }


        }
        class MainClass
        {
            public static void Main(string[] args)
            {
                student student1 = new student("shahad", 20, 287);

                student student2 = (student)student1.Shallowcopy();
                student2.infoid.id = 3;
                Console.WriteLine(student2.infoid.id);
                Console.WriteLine(student1.infoid.id);

                student student3 = new student("ali", 30, 456);
                Console.WriteLine(student3.infoid.id);

                student student4 = (student)student1.DeepCopy();
                student4.infoid.id = 6;
                Console.WriteLine(student4.infoid.id);


            }
        }
    }

