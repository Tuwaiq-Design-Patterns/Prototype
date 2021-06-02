using System;

namespace PrototypeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.name = "Ran";
            std.age = 27;
            InfoID info = new InfoID();
            info.id = 112;
            std.infoID = info;
            Console.WriteLine("Shallow Copy");
            Console.Write("the original >>");
            std.print();
            Console.Write("the copy >>");
            Student copyStd = std.shallowCopy();
            copyStd.print();
            copyStd.infoID.id = 3;
            copyStd.name = "Haneen";
            Console.Write("updated copy >>");
            copyStd.print();
            Console.Write("check original >>");
            std.print();



            Student std2 = new Student();
            std2.name = "Ran";
            std2.age = 27;
            InfoID info2 = new InfoID();
            info2.id = 112;
            std2.infoID = info2;
            Console.WriteLine("\nDeep Copy");
            Console.Write("the original >>");
            std2.print();
            Console.Write("the copy >>");
            Student copyStd2 = std2.deepCopy();
            copyStd2.print();
            copyStd2.infoID.id = 3;
            copyStd2.name = "Haneen";
            Console.Write("updated copy >>");
            copyStd2.print();
            Console.Write("check original >>");
            std2.print();
        }
    }

    public class Student
    {
        public string name;
        public int age;
        public InfoID infoID;
        
        public Student shallowCopy()
        {
            return (Student) this.MemberwiseClone();
        }

        public Student deepCopy()
        {
            Student copy= (Student)this.MemberwiseClone();
            InfoID copyInfo = new InfoID();
            copyInfo.id = this.infoID.id;
            copy.infoID = copyInfo;
            return copy;
        }

        public void print()
        {
            Console.WriteLine(' '+this.name+' '+this.age+' '+this.infoID.id);
        }

    }

    public class InfoID
    {
        public int id;
    }
}
