using System;

namespace firstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Kilonuzu girin:");
                string inputWeight = Console.ReadLine();
                int weight = Convert.ToInt32(inputWeight);

                Console.WriteLine("Boyunuzu metre olarak girin:");
                string inputHeight = Console.ReadLine();
                double height = Convert.ToDouble(inputHeight);

                double bmi = weight / (height * height);
                Console.WriteLine("BMI değeriniz: " + bmi + " bilginize");
                Console.WriteLine($"BMI değeriniz: {bmi}\nbilginize!");
            }
            catch (System.Exception)
            {

                throw;
            }


        }
    }
}
