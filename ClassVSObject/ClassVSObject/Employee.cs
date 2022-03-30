using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVSObject
{
    public class Employee
    {
        private string name;
        //public string LastName;
        private int age;

        //Bir employee ...... yapar / ile ...... yapılır

        public void SetAge(int value)
        {
            if (value < 18)
            {
                throw new ArgumentException("Yaş 18'den küçük olamaz");
            }
            age = value;
        }

        public int GetAge()
        {
            return age;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("ad boş olamaz!");
                }
                name = value;
            }
        }

        public string LastName { get; set; }
        public string Department { get; set; }

        public double HourlyPayment { get; set; }
        public int WorkingHours { get; set; }
        public double Salary
        {
            get
            {
                return HourlyPayment * WorkingHours;
            }
        }
        public string TCIdentityNo { get; set; }
        public bool IsMarried { get; set; }

       // private bool isMarried;








    }
}
