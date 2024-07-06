using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adventure_Quest_RPG
{
    public abstract class Items
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract void Use(Player player);

    }

    public class Potion : Items
    {
        public int Medicine{ get; private set; }

        public Potion (string name, int medicine)
        {
            Name = name;
            Description = "A magical potion that heals the player when consumed.";
            Medicine = medicine;
        }

        public override void Use(Player player)
        {
            player.EquipItem(this);
        }

    }
    public class DefensiveStructures : Items
    {
        public int defensive_Structures { get; private set; }

        public DefensiveStructures(string name, int defensive_structures)
        {
            Name = name;
            Description = "Structures built to defend against attacks and withstand damage.";
            defensive_Structures = defensive_structures;
        }

        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }
    public class ThunderSpears : Items
    {
        public int thunder_Spears { get; private set; }

        public ThunderSpears(string name, int thunder_spears)
        {
            Name = name;
            Description = "Powerful spears capable of delivering electric shocks.";
            thunder_Spears = thunder_spears;
        }

        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }
    public class PersonalArmor : Items
    {
        public int Armor { get; private set; }

        public PersonalArmor(string name, int armor)
        {
            Name = name;
            Description = "Armor designed to protect the wearer's health.";
            Armor = armor;
        }

        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }
    public class UltrahardSteelBlades : Items
    {
        public int Blades { get; private set; }

        public UltrahardSteelBlades(string name, int blades)
        {
            Name = name;
            Description = "Extremely sharp blades made of ultrahard steel.";
            Blades = blades;
        }

        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }
    public class ODM_Gear : Items
    {
        public int Repo { get; private set; }

        public ODM_Gear(string name, int repo)
        {
            Name = name;
            Description = "Advanced maneuvering equipment for defense.";
            Repo = repo;
        }

        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }


}
