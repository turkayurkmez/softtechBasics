using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            showMessage("işlem tamam");
            Console.WriteLine("Bir sayı girin:");
            int x = int.Parse(Console.ReadLine());
            //if (isEven(x))
            //{
            //    Console.WriteLine("Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Tektir");
            //}

            Console.WriteLine(isEven(x) ? "Çifttir" : "Tektir");
            int[] weathers = { 22, 19, 0, 36, 52 };
            showMessage($"en yüksek sıcaklık: {getMaxNumber(weathers)}");
        }

        static void showMessage(string message)
        {
            Console.WriteLine(message);
        }

        static bool isEven(int number)
        {
            return number % 2 == 0;
        }

        static int getMaxNumber(int[] numbers)
        {
            return numbers.ToList().Max();
        }

    }
}
