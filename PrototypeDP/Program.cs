using System;

namespace PrototypeDP
{
    class Department
    {
        public int Id;
        public string Address;

        public Department(int id, string address)
        {
            this.Id = id;
            this.Address = address;
        }

    }
    class Employee
    {
        public int Id { set; get; }
        public string Name;
        public Department Dep;


        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }


        public Employee DeepCopy()
        {
            Employee other = (Employee)this.MemberwiseClone();
            other.Dep = new Department(this.Dep.Id,this.Dep.Address);
            other.Name = String.Copy(Name);
            return other;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee Hussain = new Employee() { Id = 1, Name = "Hussain", Dep = new Department(1,"building 1") };

            Employee Ahmed = Hussain.ShallowCopy();

            Ahmed.Dep.Id = 7;
            Console.WriteLine("----------ShallowCopy----------");
            Console.WriteLine(Hussain.Name + "'s Department Id is: " + Hussain.Dep.Id + "'s Department address is: " + Hussain.Dep.Address);
            Console.WriteLine(Ahmed.Name + "'s Department Id is: " + Ahmed.Dep.Id + "'s Department address is: " + Ahmed.Dep.Address);


            Employee Rayan = Hussain.DeepCopy();
            Rayan.Name = "Rayan";
            Ahmed.Id = 3;

            Rayan.Dep.Id = 7;
            Console.WriteLine("\n------------DeepCopy-----------");
            Console.WriteLine(Hussain.Name + "'s Department Id is: " + Hussain.Dep.Id + "'s Department address is: " + Hussain.Dep.Address);
            Console.WriteLine(Rayan.Name + "'s Department Id is: " + Rayan.Dep.Id + "'s Department address is: " + Rayan.Dep.Id);
        }
    }
}