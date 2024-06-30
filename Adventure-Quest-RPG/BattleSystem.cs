using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class BattleSystem
    {
        public static void Attack(Character attacker, Character target )
        {
            int damage =Math.Max( attacker.AttackPower - target.Defense , 0);
            target.CalcDamage(damage);
            Console.WriteLine("    #     ####### #######   #     #####   #   #");
            Console.WriteLine("   # #       #       #     # #   #     #  #  #");
            Console.WriteLine("  #####      #       #    #####  #        ###");
            Console.WriteLine(" #     #     #       #   #     # #     #  #  #");
            Console.WriteLine("#       #    #       #  #       # #####   #   #");

            Console.WriteLine($"{attacker.Name}Player\tYour Power:{attacker.AttackPower}\tYour Health{damage}%\n{target.Name} Health:{target.Health}%");        }
    
    }
}
