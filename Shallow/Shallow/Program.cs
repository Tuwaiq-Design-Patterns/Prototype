using System;

namespace Shallow
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp emp1 = new Emp();
            emp1.name = "Ahmed";
            emp1.age = 23;
            emp1.depId = new DepId(){id = 12};

            Emp emp2 = emp1.ShallowCopy();
            Emp emp3 = emp1.DeepCopy();
            
            Console.WriteLine("emp1 is the Orignal");
            Console.WriteLine("emp2 is the ShallowCopy");
            Console.WriteLine("emp3 is the DeepCopy");
            Console.WriteLine();
            
            Console.WriteLine("Before:");
            Console.WriteLine("emp1 name: " + emp1.name);
            Console.WriteLine("emp2 name: " + emp2.name);
            Console.WriteLine("emp3 name: " + emp3.name);
            Console.WriteLine("emp1 depId: " + emp1.depId.id);
            Console.WriteLine("emp2 depId: " + emp2.depId.id);
            Console.WriteLine("emp3 depId: " + emp3.depId.id);

            emp1.name = "IBRA";
            emp2.name = "Luay";
            emp3.name = "Yoss";

            emp1.depId.id = 145;
            emp2.depId.id = 33;
            emp3.depId.id = 56;
            
            Console.WriteLine("After:");
            Console.WriteLine("emp1 name: " + emp1.name);
            Console.WriteLine("emp2 name: " + emp2.name);
            Console.WriteLine("emp3 name: " + emp3.name);
            Console.WriteLine("emp1 depId: " + emp1.depId.id);
            Console.WriteLine("emp2 depId: " + emp2.depId.id);
            Console.WriteLine("emp3 depId: " + emp3.depId.id);
        }
        
        
    }

    class Emp
    {
        public string name { set; get; }
        public int age { set; get; }
        public DepId depId { set; get; }
        
        public Emp ShallowCopy()
        {
            return (Emp) this.MemberwiseClone();
        }

        public Emp DeepCopy()
        {
            Emp other = (Emp) this.MemberwiseClone();
            other.depId = new DepId(){id = depId.id};
            return other;
        }
    }

    class DepId
    {
        public int id { set; get; }
    }
}