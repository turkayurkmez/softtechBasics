using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IDepartment Department { get; set; }


    }

    public class Department : IDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Employee> Employees { get; set; }
        public Employee Manager { get; set; }
        public double Budget { get; set; }

        public bool ExtraProperty { get; set; }
    }


    public interface IDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class AutonomicDepartment : IDepartment
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
