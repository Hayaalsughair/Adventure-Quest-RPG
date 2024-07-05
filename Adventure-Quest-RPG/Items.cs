using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int Medicine { get; set; }

        public override void Use(Player player)
        {
            player.Health += Medicine;
        }

    }
    public class Sword : Items 
    { 
        public int MasterSword  { get; set; }
        public override void Use(Player player)
        {
            player.AttackPower += MasterSword;
        }
    }
    public class Helmet: Items
    {
        public int MilitaryHelmet { get; set; }
        public override void Use(Player player)
        {
            player.Defense += MilitaryHelmet;
        }
    }
    public class Weapon : Items
    { 
        public int Axe { get; set; }
        public override void Use(Player player)
        {
            player.AttackPower += Axe;
        }
    }
    public class Armor : Items
    { 
        public int Vist { get; set; }
        public override void Use(Player player)
        {
            player.Defense += Vist;
        }
    }
}
