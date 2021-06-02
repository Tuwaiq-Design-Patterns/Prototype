using System;

namespace protoType
{
    public class info
    {
        public int id;
        public info(int id)
        {
            this.id = id;
        }
    }
    public class Employe
    {
        public string name;
        public int age;
        public info infoid;
        public Employe(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.infoid = new info(id);
        }
        public object Shallowcopy()
        {
            return (Employe)this.MemberwiseClone();
        }
        public Employe DeepCopy()
        {
            Employe Employ = new Employe(this.name, this.age, infoid.id);
            return Employ;
        }
        public Employe DeepCopy2()
        {
            Employe e = (Employe)this.MemberwiseClone();
            e.infoid = new info(infoid.id);
            e.name = String.Copy(name);
            return e;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Employe Em1 = new Employe("Ahmad", 22, 2);
            Employe Em2 = (Employe)Em1.Shallowcopy();

            Em2.infoid.id = 3;

            Console.WriteLine(Em2.infoid.id);
            Console.WriteLine(Em1.infoid.id);
            Employe Em3 = new Employe("ali", 30, 333);
            Employe Em4 = (Employe)Em1.DeepCopy();
            Employe Em5 = new Employe("ali", 30, 222);
            Employe Em6 = (Employe)Em1.DeepCopy2();

            Console.WriteLine(Em3.infoid.id);
            Em4.infoid.id = 77;
            Em5.infoid.id = 99;
            Console.WriteLine(Em4.infoid.id);
            Console.WriteLine(Em5.infoid.id);
        }
    }
}