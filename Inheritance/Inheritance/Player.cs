using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Player
    {

        public Weapon PlayersGun { get; set; }
    }

    public class Weapon
    {

    }

    public class ShotGun:Weapon
    {

    }

    public class AutoShutGun : ShotGun
    {

    }
    public class ManuelShutGun:ShotGun
    {

    }

    public class Knife:Weapon
    {

    }
}
