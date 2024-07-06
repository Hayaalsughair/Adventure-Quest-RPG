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
    public class Sword : Items 
    { 
        public int MasterSword  { get; set; }
        public Sword(string name , int masterSword)
        {
            Name = name;
            Description = "A powerful sword that increases the player's attack power.";
            MasterSword = masterSword;
        }
        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }
    public class Helmet: Items
    {
        public int MilitaryHelmet { get; set; }
        public Helmet(string name , int militaryHelmet)
        {
            Name = name;
            Description = "A sturdy helmet that provides additional defense to the player.";
            MilitaryHelmet = militaryHelmet;
        }
        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }
    public class Weapon : Items
    { 
        public int Axe { get; set; }
        public Weapon(string name , int axe)
        {
            Name = name;
            Description = "An Axe that enhances the player's attack power.";
            Axe = axe;
        }
        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }
    public class Armor : Items
    { 
        public int Vist { get; set; }
        public Armor(string name , int vist)
        {
            Name = name;
            Description = "Protective armor that increases the player's defense.";
            Vist = vist;
        }
        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }
   
}
