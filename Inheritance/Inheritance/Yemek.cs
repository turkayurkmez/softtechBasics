using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Yemek
    {
        public double Fiyat { get; set; }
        public int PismeSuresi { get; set; }
        public List<string> Malzemeleri { get; set; }

        public void Hazirla() 
        {
            Console.WriteLine("hazırlanıyor...");

        }
        public void Pisir()
        {
            Console.WriteLine($"{this.GetType().Name}, {PismeSuresi} saniyede pişti");
        }

        //Polymorphism: Base class'daki bir üyenin derived class içinde de olmasını fakat bambaşka bir biçimde çalışmasıdır
        public virtual void SunumYap()
        {
            Console.WriteLine($"{this.GetType().Name}, yanında pilav ile sunuldu");
        }

    }

    public class SebzeYemek : Yemek
    {
        public bool ZeytinYagliMi { get; set; }
        public bool SogukMu { get; set; }

    }

    public class Kurufasulye: Yemek
    {

    }
    //Eğer pırasa nesnesine özel bir property (get; set;) veya metot yoksa; o zaman pırasa nesnesine de gerek yoktur. 
    public class Pirasa : SebzeYemek
    {
        public int HavucAdedi { get; set; }
        public bool LimonOlsunMu { get; set; }

        public override void SunumYap()
        {
            Console.WriteLine($"{this.GetType().Name}, normal bir biçimde sunuldu");
        }
    }

    public class EtYemegi : Yemek
    {
        public bool SoganOlsunMu { get; set; }

    }

    public class Kebap : EtYemegi
    {
        public int LavasAdedi { get; set; }
    }


}
