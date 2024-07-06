using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
        }
        public void EquipItem(Items item)
        {
            if (item is Potion)
            {
                AttackPower += ((Potion)item).Medicine;
                Console.WriteLine($"{item.Name} equipped. Attack power increased by {((Potion)item).Medicine}.");
            }
            else
            if (item is Sword)
            {
                AttackPower += ((Sword)item).MasterSword;
                Console.WriteLine($"{item.Name} equipped. Attack power increased by {((Sword)item).MasterSword}.");
            }
            else
            if (item is Weapon)
            {
                AttackPower += ((Weapon)item).Axe;
                Console.WriteLine($"{item.Name} equipped. Attack power increased by {((Weapon)item).Axe}.");
            }
            else
            if (item is Armor)
            {
                AttackPower += ((Armor)item).Vist;
                Console.WriteLine($"{item.Name} equipped. Attack power increased by {((Armor)item).Vist}.");
            }
            else
            if (item is Helmet)
            {
                Defense += ((Helmet)item).MilitaryHelmet;
                Console.WriteLine($"{item.Name} equipped. Defense increased by {((Helmet)item).MilitaryHelmet}.");
            }
        }


    }
}
