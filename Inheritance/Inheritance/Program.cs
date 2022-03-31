using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Asci asci = new Asci();
            Yemek yemek = new Yemek { PismeSuresi = 150 };
            SebzeYemek sebzeYemegi = new SebzeYemek();
            Pirasa pirasa = new Pirasa() { PismeSuresi = 200 };
            Kebap kebap = new Kebap { LavasAdedi = 4, PismeSuresi = 300, SoganOlsunMu = true };
            asci.Pisir(pirasa);
            asci.Pisir(kebap);
            Player player = new Player();
            player.PlayersGun = new AutoShutGun();
        }
    }
}
