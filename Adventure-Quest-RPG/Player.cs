using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Adventure_Quest_RPG
{

    public class Player:Character
    {
        public Inventory Inventory { get; set; }
        //Random random = new Random();
        public Player( string name  , int attackPower = 60) {

            Name = name;
            Health = 100;
            AttackPower = attackPower;
            Defense = 18;
            Inventory = new Inventory();

        }
        public void UseItem(Items item)
        {
            item.Use(this);
            Inventory.Remove(item);
        }


    }
}
