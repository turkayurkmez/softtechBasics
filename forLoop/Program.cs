using System;
using System.Collections.Generic;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Adana");
            cities.Add("Urfa");
            cities.Add("Istanbul");
            cities.Add("Ankara");
            cities.Add("Eskişehir");
            cities.Add("Istanbul");
            cities.Add("Istanbul");

            for (int i = 0; i < cities.Count; i++)
            {
                //eğer belirli bir koşul gerçekleştiğinde döngü eylemi yapmadan (pas geçerek) işleme devam edecekse continue ifadesi kullanılır.
                //if (cities[i]=="Istanbul")
                //{
                //    continue;
                //}
                Console.WriteLine(cities[i]);
            }

            List<int> numbers = new List<int> {16,4,56,-3,21  };
            int enKucuk = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (enKucuk > numbers[i])
                {
                    enKucuk = numbers[i];
                }
            }
            Console.WriteLine($"en küçük değer:{enKucuk}");

            Console.WriteLine("aradığınız şehri girin");
            string city = Console.ReadLine();
            bool isExist = false;
            for (int i = 0; i < cities.Count; i++)
            {
                if (cities[i] == city)
                {
                    isExist = true;
                    break;
                }
            }

            if (isExist)
            {
                Console.WriteLine($"{city} koleksiyonda var");
            }
            else
            {
                Console.WriteLine($"{city} koleksiyonda yok");

            }




        }
    }
}
