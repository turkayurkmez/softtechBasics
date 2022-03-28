using System;

namespace BMICalculator
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
                if (double.IsFinite(bmi))
                {
                    Console.WriteLine("BMI değeriniz: " + bmi + " bilginize");
                    Console.WriteLine($"BMI değeriniz: {bmi}\nbilginize!");

                }
                else
                {
                    Console.WriteLine("Boy, 0'dan faklı olmalı");
                }
              
            }
            catch (FormatException)
            {
                //Ctrl+K+D
                Console.WriteLine("Lütfen sayısal değer girin!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine();
            }


        }
    }
}
