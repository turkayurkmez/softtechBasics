using System;

namespace LooselyCoupled
{
    class Program
    {
        static void Main(string[] args)
        {
            Department it = new Department() { Name = "Bilgi İşlem", Budget = 750000 };
            

            Employee employee = new Employee { Name = "Türkay", Department = it };
            employee.Department = it;
            

            Console.WriteLine($"Çalışanın departmanının bütçesi: {employee.Department.Budget}");
        }
    }
}
