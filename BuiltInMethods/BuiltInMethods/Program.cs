using System;
using System.Collections.Generic;

namespace BuiltInMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "softtech";
            var subString = "";
            var charIndex = 0;
            while (charIndex <word.Length)
            {
                System.Threading.Thread.Sleep(100);
                subString = word.Substring(charIndex);
                charIndex++;
                Console.WriteLine(subString);
                //Console.Clear();
            }
            //Console.WriteLine(subString);
           
            Random randomNumberGenerator = new Random();
            int number = randomNumberGenerator.Next(0, 10);

            List<string> cities = new List<string> { "Adana", "Urfa", "İstanbul" };
           
            if (cities.Contains("Adana"))
            {
                Console.WriteLine("Adana koleksiyonda var!");
            }
            else
            {
                Console.WriteLine("Adana koleksiyonda yok!");
            }

            cities.Sort();
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("Bir şifre giriniz");
            string password = Console.ReadLine();
            //sadece harf ya da rakam ise zayıf
            //Büyük harf küçük harf ve sayı ise orta
            //Sayı harf ve alfanumerik olmayan karakter varsa güçlü
            bool sayiMi = false;
            bool harfMi = false;
            bool buyukHarfMi = false;
            bool kucukHarfMi = false;
            bool alfaNumerikDegilMi = false;

            foreach (var character in password)
            {
                if (char.IsDigit(character))
                {
                    sayiMi = true;
                }
                else if (char.IsLetter(character))
                {
                    harfMi = true;
                    if (char.IsLower(character))
                    {
                        kucukHarfMi = true;
                    }
                    else
                    {
                        buyukHarfMi = true;
                    }
                }
                else
                {
                    alfaNumerikDegilMi = true;
                }
            }

            if ((sayiMi && !harfMi && !alfaNumerikDegilMi) || (harfMi && !sayiMi && !alfaNumerikDegilMi) )
            {
                Console.WriteLine("Zayıf");
            }
            else if (sayiMi && harfMi && buyukHarfMi && kucukHarfMi && !alfaNumerikDegilMi)
            {
                Console.WriteLine("Orta");
            }
            else if (sayiMi && harfMi && alfaNumerikDegilMi)
            {
                Console.WriteLine("Güçlü");
            }

            


        }
    }
}
