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
            switch (item)
            {
                case Potion potion:
                    // Example logic for potions
                    Console.WriteLine($"{potion.Name} equipped. Use logic for potions.");
                    break;

                case DefensiveStructures D_structures:
                    // Example logic for defensive structures
                    Console.WriteLine($"{D_structures.Name} equipped. Use logic for defensive structures.");
                    break;

                case ThunderSpears thunderSpears:
                    // Example logic for ThunderSpears
                    Console.WriteLine($"{thunderSpears.Name} equipped. Use logic for ThunderSpears.");
                    break;

                case PersonalArmor personalArmor:
                    // Example logic for PersonalArmor
                    Console.WriteLine($"{personalArmor.Name} equipped. Use logic for PersonalArmor.");
                    break;

                case UltrahardSteelBlades steelBlades:
                    // Example logic for UltrahardSteelBlades
                    Console.WriteLine($"{steelBlades.Name} equipped. Use logic for UltrahardSteelBlades.");
                    break;

                case ODM_Gear odmGear:
                    // Example logic for ODM_Gear
                    Console.WriteLine($"{odmGear.Name} equipped. Use logic for ODM_Gear.");
                    break;

                default:
                    Console.WriteLine($"Cannot equip {item.Name}. Item type not recognized.");
                    break;
            }
        }
    }
}



    

