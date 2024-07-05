using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Adventure_Quest_RPG
{

    public class Player:Character
    {
        //Random random = new Random();
        public Player( string name  , int attackPower = 60) {

            Name = name;
            Health = 100;
            AttackPower = attackPower;
            Defense = 18; 
            Inventory inventory= new Inventory();
        }
        public void calcItemsDrop(string chanceItems) {
            
            switch (chanceItems)
            {
                case "Potion":
                    Health += 30;
                    break;
                case "Armor":
                    Defense += 10;
                    break;
                case "Weapon":
                    AttackPower += 10;
                    break;
                case "Helmet":
                    Defense += 5;
                    break;
                case "Sword":
                    AttackPower += 5;
                    break;
            }
        }
    }
}
