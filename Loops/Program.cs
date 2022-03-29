using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ctrl + K  + C 

            // bool uygulamaDevamEtsinMi = true ;
            // while (uygulamaDevamEtsinMi)
            // {
            //     Console.WriteLine("Bir sayi giriniz:");
            //     int num1 = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Bir sayi daha giriniz:");
            //     int num2 = Convert.ToInt32(Console.ReadLine());

            //     int carpim = num1 * num2;
            //     Console.WriteLine($"Çarpım sonucu: {carpim}");
            //     System.Console.WriteLine("Bir işlem daha yapmak ister misiniz (E/H) ?");
            //     uygulamaDevamEtsinMi = Console.ReadLine() == "E";
            // }

            //aynı işin alternatifi:
            do
            {
                Console.WriteLine("Bir sayi giriniz:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bir sayi daha giriniz:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int carpim = num1 * num2;
                Console.WriteLine($"Çarpım sonucu: {carpim}");
                System.Console.WriteLine("Bir işlem daha yapmak ister misiniz (E/H) ?");
            } while (Console.ReadLine()=="E");



        }
    }
}
