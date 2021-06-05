using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ObjectCopyTest
{
  [Serializable()]  
public class DepartmentId{
    public int id ;
    
    public DepartmentId ShallowCopy()
    {
        return (DepartmentId) this.MemberwiseClone();
    }
    }
[Serializable()]
public class Employee{
    public string name;
    public int age;
    public DepartmentId departmentId;

    public Employee ShallowCopy()
    {
        return (Employee) this.MemberwiseClone();
    }
    
    public Employee DeepCopy()
    {
        Employee other = (Employee) this.MemberwiseClone();
        other.departmentId = this.departmentId.ShallowCopy();
        return other;
    }
    public Employee DeepCopyS()
    {
        MemoryStream stream = new MemoryStream();
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream , this);
        stream.Seek(0, SeekOrigin.Begin);
        Employee copy = (Employee) formatter.Deserialize(stream);
        stream.Close();
        return copy;
    }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
           Employee ahmed = new Employee()
           {
               name = "Ahmed",
               age = 24,
               departmentId = new DepartmentId(){id = 1}
           };
           
           Employee mohammed = ahmed.DeepCopy();
           mohammed.name = "Mohammed";
           mohammed.departmentId = new DepartmentId(){id = 2};

           Console.WriteLine($"{ahmed.name} age is {ahmed.age} and his department {ahmed.departmentId.id} ," +
                             $" and {mohammed.name} age is {mohammed.age} and his department {mohammed.departmentId.id}");
        }
    }
}