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

        public BattleSystem() {

            chosenDropedItems();
            random = new Random();
        }

        public void Attack( IBattleStates attacker, IBattleStates target)
        {

            //Console.WriteLine($"Round :{Round}\n");

            int damage = Math.Max(attacker.AttackPower - target.Defense, 0);
            target.CalcDamage(damage);

            Thread.Sleep(600);

            Console.Beep();
            Console.Beep(); 
            Console.Beep();
            Console.WriteLine("\n\n");
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

            Console.WriteLine($"\n\nThe Damage Is :{damage}");
            Console.WriteLine($"Attacker Name :{attacker.Name}\t\tAttacker Health{attacker.Health}%");
            Console.WriteLine($"Target Name:{target.Name}\tTarget Health:{target.Health}%");
            Thread.Sleep(5000);
            //Console.Clear();
        }

        public  bool StartBattle(Player player, Monster enemy)
        {
           
            bool isPlayerWin = false;
            while (player.Health > 0 && enemy.Health > 0)
            {

                //Random++;
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
                    Console.WriteLine("Ooh! You Still Alive ,Monster Is Defeated");
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
                new Potion("Healing Potion", 20),
                new DefensiveStructures(" Fortress ", 50),
                new ThunderSpears("Thunder Spears", 30),
                new PersonalArmor(" Steel Armor ", 10),
                new UltrahardSteelBlades(" Steel Blades ", 40),
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
