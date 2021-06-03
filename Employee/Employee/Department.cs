using System;
namespace Employee
{
    public class Department
    {
        public int id;
        public String Name;

        public Department(int id, string name)
        {
            this.id = id;
            Name = name;
        }

        public String SetNameDepartment(String name)
        {
            return this.Name=name;
        }

        public String getNameDepartment()
        {
            return this.Name;
        }
        public Department()
        {
        }
    }
}
