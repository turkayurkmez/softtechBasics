using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
   public class CamasirMakinesi
    {
        public string Renk { get; set; }
        public int CalismaHizi { get; set; }
        public string EnerjiTuketimi { get; set; }

        public CamasirMakinesi()
        {
            Renk = "Beyaz";
            CalismaHizi = 800;
        }

        public CamasirMakinesi(string renk)
        {
            Renk = renk;
        }


    }
}
