using System;
using System.Collections.Generic;

namespace ArrayAndCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = new string[] { "Aygün Mercan", "Buğra Güneş", "Çağla Turkut" };
            string[] mevsimler = { "Sonbahar", "İlkbahar", "Yaz", "Kış" };


            int[] onGunlukHavaDurumu = new int[10];
            onGunlukHavaDurumu[0] = 15;
            onGunlukHavaDurumu[1] = 10;
            onGunlukHavaDurumu[2] = 25;
            onGunlukHavaDurumu[1] = 30;

            //36 = otuz altı


            //Console.WriteLine(participants[0]);
            //Console.WriteLine(participants[1]);
            Console.WriteLine(participants[participants.Length-1]);

            string[] onlar = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] birler = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };

            Console.WriteLine("iki basamaklı bir sayı girin:");

            int sayi = int.Parse(Console.ReadLine());
            int onlarBasamagindakiDeger = sayi / 10;
            int birlerBasamagindakiDeger = sayi % 10;

            Console.WriteLine($"{onlar[onlarBasamagindakiDeger]} {birler[birlerBasamagindakiDeger]}");

            List<string> products = new List<string>();
            products.Add("Gazete");
            products.Add("Şişe");

            List<double> prices = new List<double>();
            List<DateTime> tatilGunleri = new List<DateTime>();
            

            






        }
    }
}
