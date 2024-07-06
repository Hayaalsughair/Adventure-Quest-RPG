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
        
        public Player( string name) {

            Name = name;
            Health = 200;
            AttackPower = 200;
            Defense = 50;
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
                    Health += potion.Medicine;
                    Console.WriteLine($"{potion.Name}: Your Health will increase +50  ");
                    break;

                case DefensiveStructures D_structures:
                    Health += D_structures.defensive_Structures;
                    Console.WriteLine($"{D_structures.Name}: It will increase your Health +50");
                    break;

                case ThunderSpears thunderSpears:
                    AttackPower += thunderSpears.thunder_Spears;
                    Console.WriteLine($"{thunderSpears.Name}: Your Attack Power increase +30");
                    break;

                case PersonalArmor personalArmor:
                    Defense += personalArmor.Armor;
                    Console.WriteLine($"{personalArmor.Name}: Your Defense will increase +30");
                    break;

                case UltrahardSteelBlades steelBlades:
                    AttackPower += steelBlades.Blades;
                    Console.WriteLine($"{steelBlades.Name}: Your Attack Power increase +50");
                    break;

                case ODM_Gear odmGear:
                    Defense += odmGear.Repo;
                    Console.WriteLine($"{odmGear.Name} equipped. Use logic for ODM_Gear.");
                    break;

                default:
                    Console.WriteLine($"Cannot equip {item.Name}. Item type not recognized.");
                    break;
            }
        }
    }
}



    

