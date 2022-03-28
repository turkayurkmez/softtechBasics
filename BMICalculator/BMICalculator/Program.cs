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
                //bmi değeri sonlu bir değerse
                if (double.IsFinite(bmi) && bmi > 0)
                {
                    //Console.WriteLine("BMI değeriniz: " + bmi + " bilginize");
                    Console.WriteLine($"BMI değeriniz: {bmi} bilginize!");

                    if (bmi < 18.5)
                    {
                        Console.WriteLine("Çok zayıfsınız!");
                    }
                    else if (bmi <=24.9)
                    {
                        Console.WriteLine("Normalsiniz");
                    }
                    else if (bmi <=29.9 )
                    {
                        Console.WriteLine("Biraz kilolusunuz");
                    }
                    else
                    {
                        Console.WriteLine("Obez");
                    }




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
            catch(Exception ex)
            {
                if (ex is DivideByZeroException)
                {

                }
            }

        }
    }
}
