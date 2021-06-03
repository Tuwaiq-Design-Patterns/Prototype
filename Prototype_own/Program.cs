using System;

namespace Prototype
{
    class Dep
    {
        public int Id { get; set; }
    }
    class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dep Dep_id { get; set; }
        public Emp ShallowCopy() => (Emp)this.MemberwiseClone();
        public Emp DeepCopy()
        {
            Emp other = (Emp)this.MemberwiseClone();
            other.Dep_id = new Dep { Id = Dep_id.Id };
            other.Name = Name;
            return other;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp ahmed0 = new Emp { Id = 1, Name = "Ahmed", Dep_id = new Dep { Id = 2 } };
            Console.WriteLine("\n >> SOFT COPY <<:\n");
            Emp ahmed1 = ahmed0.ShallowCopy();
            Console.WriteLine("Original values of ahmed0 and ahmed1:");
            Console.WriteLine(" ahmed0 instance values: ");
            Console.WriteLine("      "+ahmed0.Id + " " + ahmed0.Dep_id.Id + " " + ahmed0.Name);
            Console.WriteLine(" ahmed2 instance values:");
            Console.WriteLine("      "+ahmed1.Id + " " + ahmed1.Dep_id.Id + " " + ahmed1.Name);
            ahmed0.Id = 32;
            ahmed0.Name = "Salim";
            ahmed0.Dep_id.Id = 7878;
            Console.WriteLine("\nValues of ahmed0 and ahmed1 after changes to ahmed0:");
            Console.WriteLine(" ahmed0 instance values: ");
            Console.WriteLine("      "+ahmed0.Id + " " + ahmed0.Dep_id.Id + " " + ahmed0.Name);
            Console.WriteLine(" ahmed1 instance values:");
            Console.WriteLine("      "+ahmed1.Id + " " + ahmed1.Dep_id.Id + " " + ahmed1.Name);
            Console.WriteLine("\n >> DEEP COPY <<:\n");
            Emp mohammed = ahmed0.DeepCopy();
            Console.WriteLine("\nVOriginal values of ahmed0 and mohammed");
            Console.WriteLine(" ahmed0 instance values: ");
            Console.WriteLine("      "+ahmed0.Id + " " + ahmed0.Dep_id.Id + " " + ahmed0.Name);
            Console.WriteLine(" Mohammed instance values:");
            Console.WriteLine("      "+mohammed.Id + " " + mohammed.Dep_id.Id + " " + mohammed.Name);
            ahmed0.Name = "Khalid";
            ahmed0.Id = 39;
            ahmed0.Dep_id.Id = 8641;
            Console.WriteLine("\nValues of ahmed0 and mohammed after changes to ahmed0:");
            Console.WriteLine(" ahmed0 instance values: ");
            Console.WriteLine("      "+ahmed0.Id + " " + ahmed0.Dep_id.Id + " " + ahmed0.Name);
            Console.WriteLine(" Mohammed instance values:");
            Console.WriteLine("      "+mohammed.Id + " " + mohammed.Dep_id.Id + " " + mohammed.Name);
        }
    }
}
