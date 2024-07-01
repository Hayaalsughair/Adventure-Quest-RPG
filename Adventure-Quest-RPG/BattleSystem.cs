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

        public static void Attack(Character attacker, Character target, int round)
        {
            Console.WriteLine($"Round :{round}\n");

            int damage = Math.Max(attacker.AttackPower - target.Defense, 0);
            target.CalcDamage(damage);

            Thread.Sleep(500);

            Console.Beep();
            Console.Beep();
            Console.Beep();

            Console.WriteLine("\t\t          ###        ############# #############       ###               ######      ##      ##");
            Console.WriteLine("\t\t         #####       ############# #############      #####             ########     ##     ##");
            Console.WriteLine("\t\t        ##   ##            ##           ##           ##   ##           ##      ##    ##    ##");
            Console.WriteLine("\t\t       ###   ###           ##           ##          ###   ###          ##      ##    ##   ##");
            Console.WriteLine("\t\t      ###########          ##           ##         ###########         ##            #####");
            Console.WriteLine("\t\t     #############         ##           ##        #############        ##            #####");
            Console.WriteLine("\t\t    ##           ##        ##           ##       ##           ##       ##      ##    ##   ##");
            Console.WriteLine("\t\t   ##             ##       ##           ##      ##             ##      ##      ##    ##    ##");
            Console.WriteLine("\t\t  ##               ##      ##           ##     ##               ##      ########     ##     ##");
            Console.WriteLine("\t\t ##                 ##     ##           ##    ##                 ##      ######      ##       ##");

            Console.WriteLine($"\nThe Damage Is :{damage}");
            Console.WriteLine($"Attacker Name :{attacker.Name} \t Attacker Health{attacker.Health}%");
            Console.WriteLine($"Target Name:{target.Name}\t Target Health:{target.Health}%");
            Thread.Sleep(6000);
            Console.Clear();


        }

        public static bool StartStartBattle(Player player, Monster enemy)
        {
            int Round = 0;
            bool isPlayerWin = false;
            while (player.Health > 0 && enemy.Health > 0)
            {
                Round++;
                Console.WriteLine("Player's turn.");
                Attack(player, enemy, Round);
                Thread.Sleep(2000);
                Console.Clear();
                if (enemy.Health <= 0) {
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.WriteLine("Ooh! You Still Alive ,Monster Is Defeated");
                    Thread.Sleep(3000);
                    Console.Clear();
                    isPlayerWin = true;
                    break;

                }
                if (player.Health > 0)
                {
                    Console.WriteLine("Enemy's turn.");
                    Round++;
                    Attack(enemy, player, Round);
                }
                if (player.Health <= 0)
                {
                    Console.WriteLine($"Round :{Round}\n");

                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();

                    Console.WriteLine("\t\t########################################################################");
                    Console.WriteLine("\t\t########################################################################");
                    Console.WriteLine("\t\t##################███▀▀▀██#███▀▀▀███#███▀█▄█▀███#██▀▀▀##################");
                    Console.WriteLine("\t\t##################██####██#██#####██#██###█###██#██#####################");
                    Console.WriteLine("\t\t##################██###▄▄▄#██▄▄▄▄▄██#██###▀###██#██▀▀▀##################");
                    Console.WriteLine("\t\t##################██####██#██#####██#██#######██#██#####################");
                    Console.WriteLine("\t\t##################███▄▄▄██#██#####██#██#######██#██▄▄▄##################");
                    Console.WriteLine("\t\t########################################################################");
                    Console.WriteLine("\t\t##################███▀▀▀███#▀███##██▀#██▀▀▀#██▀▀▀▀██▄###################");
                    Console.WriteLine("\t\t##################██#####██###██##██##██####██#####██###################");
                    Console.WriteLine("\t\t##################██#####██###██##██##██▀▀▀#██▄▄▄▄▄▀▀###################");
                    Console.WriteLine("\t\t##################██#####██###▀█##█▀##██####██#####██###################");
                    Console.WriteLine("\t\t##################███▄▄▄███### ▀▀█▀▀##██▄▄▄#██#####██▄##################");
                    Console.WriteLine("\t\t########################################################################");
                    Console.WriteLine("\t\t########################################################################");
                    Console.WriteLine("\t\t##########################██###############██###########################");
                    Console.WriteLine("\t\t########################████▄###▄▄▄▄▄▄▄###▄████#########################");
                    Console.WriteLine("\t\t###########################▀▀█▄█████████▄█▀▀############################");
                    Console.WriteLine("\t\t#############################█████████████##############################");
                    Console.WriteLine("\t\t#############################██▀▀▀███▀▀▀██##############################");
                    Console.WriteLine("\t\t#############################██###███###██##############################");
                    Console.WriteLine("\t\t#############################█████▀▄▀█████##############################");
                    Console.WriteLine("\t\t##############################███████████###############################");
                    Console.WriteLine("\t\t######################### ▄▄▄██##█▀█▀█##██▄▄▄###########################");
                    Console.WriteLine("\t\t##########################▀▀██###########██▀▀###########################");
                    Console.WriteLine("\t\t############################▀▀###########▀▀#############################");
                    Console.WriteLine("\t\t########################################################################");
                    Console.WriteLine("\t\t########################################################################");

                    Thread.Sleep(3000);
                    Console.Clear();
                    isPlayerWin = false;
                    break;
                }
            }
            return isPlayerWin;

        }
        


    }
}
