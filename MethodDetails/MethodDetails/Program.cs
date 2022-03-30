using System;

namespace MethodDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            //kare, daire, dikdörtgen, üçgen   
            var squareArea = getArea(unitLength1: 10,
                                     sekil: "kare");
            var rectangleArea = getArea(5, 10, "dikdörtgen");

            Console.WriteLine($"Karenin alanı: {squareArea}, Dikdörtgen: {rectangleArea}");

            var squareAlternative = getAreaAlt(5);
            var circleAreae = getAreaAlt(8, sekil: "daire");
            var triangleArea = getAreaAlt(unitLength1: 10, unitLength2: 4, sekil: "üçgen");
        }

        static double getArea(double unitLength1, string sekil)
        {
            double result = 0.0;
            switch (sekil)
            {
                case "kare":
                    result = Math.Pow(unitLength1, 2);
                    break;
                case "daire":
                    result = Math.PI * Math.Pow(unitLength1, 2);
                    break;
                default:
                    Console.WriteLine("kare ya da daire olmalı");

                    break;
            }
            return result;
        }
        static double getArea(double unitLength1, double unitLength2, string sekil)
        {
            double result = 0.0;
            switch (sekil)
            {
                case "üçgen":
                    result = (unitLength1 * unitLength2) / 2;
                    break;
                case "dikdörtgen":
                    result = unitLength1 * unitLength2;
                    break;
                default:
                    Console.WriteLine("üçgen ya da dikdörtgen olmalı");

                    break;
            }
            return result;
        }

        static double getAreaAlt(double unitLength1, double unitLength2 = 1, string sekil = "kare")
        {
            double result = 0.0;
            switch (sekil)
            {
                case "kare":
                    result = Math.Pow(unitLength1, 2);
                    break;
                case "daire":
                    result = Math.PI * Math.Pow(unitLength1, 2);
                    break;
                case "üçgen":
                    result = (unitLength1 * unitLength2) / 2;
                    break;
                case "dikdörtgen":
                    result = unitLength1 * unitLength2;
                    break;
                default:
                    Console.WriteLine("şekli hatalı girdiniz");

                    break;
            }
            return result;
        }


    }
}
