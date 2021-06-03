using System;

namespace DP_prototype
{
    public class students
    {
        public string name;
        public int age;
        public info id;

        public students(string name, int age, info id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public object Shallowcopy()
        {
            return (students)this.MemberwiseClone();
        }

        public students DeepCopy()
        {
            students otherStudent = (students)this.MemberwiseClone();
            otherStudent.id = new info(id.id);
            return otherStudent;
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Applying Shallowcopy : ");
            students firstStudent = new students("Afra",23, new info(88));
            Console.WriteLine(firstStudent.id.id);

            students secondStudent = (students)firstStudent.Shallowcopy();
            secondStudent.id.id = 89;
            Console.WriteLine(secondStudent.id.id);

            Console.WriteLine("-------------- DeepCopy : ");
            students thirdStudent = new students("manar", 24, new info(90));
            Console.WriteLine(thirdStudent.id.id);

            students forthStudent = (students)firstStudent.DeepCopy();
            forthStudent.id.id = 91;
            Console.WriteLine(forthStudent.id.id);

        }
    }

}
