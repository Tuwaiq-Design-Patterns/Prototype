using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable()]
public class Department
{
    public int departmentID;

    public Department(int departmentID)
    {
        this.departmentID = departmentID;
    }
}

[Serializable()]
public class Employee
{
    public int Age;
    public string Name;
    public Department Department;

    public Employee ShallowCopy()
    {
       return (Employee) this.MemberwiseClone();
    }


    public Employee DeepCopy()
    {
       Employee other = (Employee) this.MemberwiseClone();
       other.Department = new Department(Department.departmentID);
       other.Name = String.Copy(Name);
       return other;
    }
    public Employee DeepCopyS()
    {
        using (MemoryStream stream = new MemoryStream())
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            Employee copy = (Employee)formatter.Deserialize(stream);
            stream.Close();
            return copy;
        }
    }
}


// The example displays the following output:
//       Original values of p1 and p2:
//          p1 instance values:
//             Name: Sam, Age: 42
//             Value: 6565
//          p2 instance values:
//             Name: Sam, Age: 42
//             Value: 6565
//
//       Values of p1 and p2 after changes to p1:
//          p1 instance values:
//             Name: Frank, Age: 32
//             Value: 7878
//          p2 instance values:
//             Name: Sam, Age: 42
//             Value: 7878
//
//       Values of p1 and p3 after changes to p1:
//          p1 instance values:
//             Name: George, Age: 39
//             Value: 8641
//          p3 instance values:
//             Name: Frank, Age: 32
//             Value: 7878