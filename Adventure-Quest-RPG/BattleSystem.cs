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
            Console.WriteLine(" #     #     #       #   #     # #     #  #   #");
            Console.WriteLine("#       #    #       #  #       # #####   #    #");

            Console.WriteLine($"{attacker.Name}Player\tYour Power:{attacker.AttackPower}\tYour Health{damage}%\n{target.Name} Health:{target.Health}%");        
        }

        public static bool startStartBattle(Player player, Monster enemy) 
        {
            bool isPlayerWin=false;
            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("Player's turn.");
                Attack(player, enemy);
                if (enemy.Health <=  0) {

                    Console.WriteLine("Ooh! You Still Alive ,Monster Is Defeated");
                    isPlayerWin = true;
                    break;

                }
                if(player.Health >0)
                {
                    Console.WriteLine("Enemy's turn.");
                    Attack(enemy,player);
                }
                if (player.Health > 0) 
                {
                    Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                    Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                    Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                    Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");

                    isPlayerWin=false;
                    break;
                }
            }
            return isPlayerWin;

        }



    }
}
