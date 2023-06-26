using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class UserStatus
    {
        public int strength { get; set; }
        public int defense { get; set; }
        public int hp { get; set; }
        public int cri { get; set; }

       public  UserStatus(int strength, int defense, int hp, int cri)
        {
            this.strength += strength;
            this.defense += defense;
            this.hp += hp;
            this.cri += cri;
        }


    }
}
