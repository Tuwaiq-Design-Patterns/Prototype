using System;

namespace DeepAndShallowCopy
{
    class student
    {
        public int id;
        
        public student(int idnum)
        {
            this.id = idnum;

        }
        
    }
    class person
    {
        public string name;
        public string hobby;
        public student id;
        public person ShallowCopy()
        {
            return (person)this.MemberwiseClone();
        }
        public person DeepCopy()
        {
            person ex = (person)this.MemberwiseClone();
            ex.id = new student(id.id);
            
            return ex;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           
            person Mosh = new person();
            Mosh.name = "mosh";
            Mosh.hobby = "Ball";
            Mosh.id = new student(13);
            
            person Thamer = Mosh.ShallowCopy();

            Thamer.name = "thamer";

            
            person Huss = Mosh.DeepCopy();
            
            Mosh.id.id = 13;
            Huss.id.id = 10;

            Huss.name = "Huss";
            Console.WriteLine(Mosh.name);
            Console.WriteLine(Huss.name);
            Console.WriteLine(Mosh.id.id);
            Console.WriteLine(Huss.id.id);

        }
    }
}
