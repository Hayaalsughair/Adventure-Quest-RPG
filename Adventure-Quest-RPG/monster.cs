using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public abstract class Monster:Character
    {
        public Monster(string name , int health , int attack_power , int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attack_power;
            Defense = defense;
        }

    }

}
