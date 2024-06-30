using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public abstract class Monster
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }


        public Monster(string name , int health , int attack_power , int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attack_power;
            Defense = defense;
        }

        //public abstract void Attack(Player player);
    }

}
