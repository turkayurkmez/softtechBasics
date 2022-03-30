using System;

namespace ClassVSObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee developer1 = new Employee();
            developer1.Name = "Kübra";
            developer1.SetAge(26);
            developer1.HourlyPayment = 800;
            developer1.WorkingHours = 40;
            Console.WriteLine(developer1.Salary);


            Console.WriteLine(developer1.GetAge());

            //Employee developer2 = developer1;
            //developer2.Name = "Rüstem";
            //developer2.Age = 31;

            //Console.WriteLine(developer1.Name);

            //Employee accountant1 = new Employee();
            //accountant1.Age = -9;

            //int input = -3;
            //if (input > 0)
            //{
            //    accountant1.Age = input;
            //}

        }
    }
}
