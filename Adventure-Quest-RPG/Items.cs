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
    }

    public class Potion : Items
    {
       
    }
    public class Sword : Items 
    { 
    }
    public class Helmet: Items
    {
    }
    public class Weapon : Items
    { 
    }
    public class Armor : Items
    { 
    }
}
