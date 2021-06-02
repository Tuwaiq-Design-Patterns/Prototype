using System;

namespace DesignPatren2
{
    public class singleton
    {
        private static singleton instance;
        private singleton() { }
        public static singleton getInstance()
        {
            if (instance == null)
            {
                instance = new singleton();
            }
            return instance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            singleton instance1 = singleton.getInstance();
            singleton instance2 = singleton.getInstance();
            Console.WriteLine(instance1);
            Console.WriteLine(instance2);
            if (instance1 == instance2)
            {
                Console.WriteLine("same instance");
            }
            else
            {
                Console.WriteLine("are not the same instance");
            }
        }
    }
}
