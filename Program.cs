using System;

namespace DesignPattern_prototype
{
    class DepId
    {
        public int Id;

        public DepId(int DepartmentId)
        {
            this.Id = DepartmentId;
        }

    }
    class Employee
    {
        public int Id { set; get; }
        public string Name;
        public DepId depId;


        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }


        public Employee DeepCopy()
        {
            Employee other = (Employee)this.MemberwiseClone();
            other.depId = new DepId(depId.Id);
            other.Name = String.Copy(Name);
            return other;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee Ahmed = new Employee(){ Id = 1, Name="Ahmed", depId = new DepId(1)};


            // Lets create a new instance by using ShallowCopy().
            Employee Majeed = Ahmed.ShallowCopy();
            Majeed.Name = "Majeed";
            Majeed.Id = 2;


            // print the info for both of Ahmed and Majeed before changing the `depId.Id` of `Majeed` object
            Console.WriteLine(Ahmed.Name + "'s Department Id is: " + Ahmed.depId.Id);
            Console.WriteLine(Majeed.Name + "'s Department Id is: " + Majeed.depId.Id);

            // Note, In ShallowCopy: if we change the `depId.Id` for Majeed, it will change for both: Majeed,Ahmed.
            Majeed.depId.Id = 5;
            Console.WriteLine("----------ShallowCopy----------");
            Console.WriteLine(Ahmed.Name +"'s Department Id is: " + Ahmed.depId.Id);
            Console.WriteLine(Majeed.Name + "'s Department Id is: " + Majeed.depId.Id);


            // Now lets create a new instance by using DeepCopy().
            Employee Sami = Ahmed.DeepCopy();
            Sami.Name = "Sami";
            Majeed.Id = 3;

            // And note, In DeepCopy: if we change the `depId.Id` for Sami, his `depId.Id` will be the only one changed.
            Sami.depId.Id = 7;
            Console.WriteLine("\n------------DeepCopy-----------");
            Console.WriteLine(Ahmed.Name + "'s Department Id is: " + Ahmed.depId.Id);
            Console.WriteLine(Sami.Name+ "'s Department Id is: " + Sami.depId.Id);
        }
    }
}