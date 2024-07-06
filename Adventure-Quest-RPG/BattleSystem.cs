﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class BattleSystem
    {
        List<Items> dropedItems;
        private Random random ;
        private int Round;

        public BattleSystem() {

            chosenDropedItems();
            random = new Random();
            Round = 0;
        }

        public void Attack( IBattleStates attacker, IBattleStates target)
        {

            Console.WriteLine($"Round :{Round}\n");

            int damage = Math.Max(attacker.AttackPower - target.Defense, 0);
            target.CalcDamage(damage);
            Console.WriteLine($"\nName: {attacker.Name} - Helth :{attacker.Health}% \t\t\t\t\t\t\t Name: {target.Name} - Helth: {target.Health}%");
            Console.WriteLine($"Power: {attacker.AttackPower}\t\t\t\t\t\t\t\t\t Power: {target.AttackPower} ");
            Console.WriteLine($"Defense:{target.Defense}\t\t\t\t\t\t\t\t\t Defense: {target.Defense} \n");

            Thread.Sleep(600);

            Console.Beep();
            Console.Beep(); 
            Console.Beep();
            Console.WriteLine("\n\n");
            Console.WriteLine("          ###        ############# #############       ###               ######      ##      ##");
            Console.WriteLine("         #####       ############# #############      #####             ########     ##     ##");
            Console.WriteLine("        ##   ##            ##           ##           ##   ##           ##      ##    ##    ##");
            Console.WriteLine("       ###   ###           ##           ##          ###   ###          ##      ##    ##   ##");
            Console.WriteLine("      ###########          ##           ##         ###########         ##            #####");
            Console.WriteLine("     #############         ##           ##        #############        ##            #####");
            Console.WriteLine("    ##           ##        ##           ##       ##           ##       ##      ##    ##   ##");
            Console.WriteLine("   ##             ##       ##           ##      ##             ##      ##      ##    ##    ##");
            Console.WriteLine("  ##               ##      ##           ##     ##               ##      ########     ##     ##");
            Console.WriteLine(" ##                 ##     ##           ##    ##                 ##      ######      ##       ##");

            Console.WriteLine($"\n\nThe Damage Is :{damage}");
          
            Thread.Sleep(5000);
            //Console.Clear();
        }

        public  bool StartBattle(Player player, Monster enemy)
        {
           
            bool isPlayerWin = false;
            while (player.Health > 0 && enemy.Health > 0)
            {

                Round++;
                Console.WriteLine("Player's turn.");

                Attack(player, enemy);
                //Thread.Sleep(2000);
               
                if (enemy.Health <= 0) {
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.WriteLine("\nOoh! You Still Alive ,Monster Is Defeated\n");
                    chanceItems(player);
                    // Thread.Sleep(2000);
                    //Console.Clear();
                    isPlayerWin = true;
                    break;

                }
                if (player.Health > 0)
                {
                    Console.WriteLine("Enemy's turn.");
                    //Round++;
                    Attack(enemy, player);
                }
                if (player.Health <= 0)
                {
                    //Console.WriteLine($"Round :{Round}\n");

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

                    //Thread.Sleep(3000);
                    //Console.Clear();
                    isPlayerWin = false;
                    break;
                }
            }
            return isPlayerWin;

        }

        public void chosenDropedItems()
        {
            dropedItems = new List<Items>
            {
                new Potion("Healing Potion", 50),
                new DefensiveStructures(" Safe Zone ", 50),
                new ThunderSpears("Thunder Spears", 30),
                new PersonalArmor(" Steel Armor ", 30),
                new UltrahardSteelBlades(" Steel Blades ", 50),
                new ODM_Gear(" Scout Regiment Gear ", 25)

            };
        }
        

        public  void chanceItems(Player player)
        {
            int randomnumber = random.Next(1,24);
            if (randomnumber <= 25)
            {
                int indexDropItem = random.Next(dropedItems.Count);
                player.Inventory.AddItem(dropedItems[indexDropItem]);
                Console.WriteLine($"You found a {dropedItems[indexDropItem].Name}!");
            }
            else
           {
                Console.WriteLine("You Did not get any item ");
           }
        }


    }
}
