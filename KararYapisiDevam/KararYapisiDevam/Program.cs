using System;

namespace KararYapisiDevam
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            if (today.Month == 7 && today.Day ==1)
            {
                Console.WriteLine("Türkay'ın doğum günü....");
            }

            Console.WriteLine("Bir ay ismi giriniz: (Örnek format: Ocak)");
            string ay = Console.ReadLine();
            if (ay=="Aralık" || ay == "Ocak" || ay=="Şubat")
            {
                Console.WriteLine("Kış");
            }
            else if (ay == "Mart" || ay == "Nisan" || ay == "Mayıs")
            {
                Console.WriteLine("İlkbahar");

            }

            Console.WriteLine("Trafik lambası seçin: (K/S/Y)");
            string secim = Console.ReadLine();
            if (secim == "K")
            {
                Console.WriteLine("Dur");
            }
            else if (secim == "S")
            {
                Console.WriteLine("Dikkat");
            }
            else if(secim == "Y") 
            {
                Console.WriteLine("Geç");

            }
            else
            {
                Console.WriteLine("Hatalı seçim");
            }


            switch (secim)
            {
                case "K":
                    Console.WriteLine("Dur");
                    break;
                case "S":
                    Console.WriteLine("Dikkat");
                    break;
                case "Y":
                    Console.WriteLine("Geç");
                    break;
                default:
                    break;
            }


            switch (ay)
            {
                case "Ocak":
                case "Subat":
                case "Mart":
                    Console.WriteLine("Kış");
                    break;
                default:
                    break;
            }


        }

    }
}
