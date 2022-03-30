using System;
using System.Linq;

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

            int modResult = 0;
            var divideResult = divide(19, 4, out modResult);
            Console.WriteLine($"Bölüm sonucu:{divideResult}, kalan: {modResult}");
            Console.ReadLine();

            Console.WriteLine("Bir sayı giriniz");
            string inputValue = Console.ReadLine();
            double aNumber = 0;
            if (double.TryParse(inputValue,out aNumber))
            {
                sample(ref aNumber);

                Console.WriteLine($"main metodundaki aNumber değeri : {aNumber}");
            }

            //A000BBB111
            string[] names = { "Feyza", "Hasan", "İnci" };
            Array.Resize(ref names, 4);
            /*
                string[] names = { "Feyza", "Hasan", "İnci","" };
             * 
             */
            names[3] = "Türkay";
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }


            int total = sum(13, 9, 122, 46, -3,45);
            Console.WriteLine($"toplam: {total}");
           


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

        static int divide(int x, int y, out int modulo)
        {
            modulo = x % y;
            return x / y;
        }

        static void sample(ref double number)
        {
            number = Math.Pow(number, 2);
            Console.WriteLine($"sample metodundaki değer:{ number}");

        }

        static int sum(params int[] numbers)
        {
            return numbers.ToList().Sum();
        }

    }
}
