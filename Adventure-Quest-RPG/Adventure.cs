using System;
using System.Collections.Generic;

namespace Adventure_Quest_RPG
{
    public class Adventure
    {
       
        private List<Monster> monster;
        public Random random = new Random();
        public Player player = new Player("shalaby", 60);
        private string chosenLocation = "Lobby";
        public BattleSystem battleSystem = new BattleSystem();
        public Adventure()
        {
            chosenMonster();
        }

        public void StartAdventure()
        {
            bool isStartPlay = true;

            while (isStartPlay)
            {
                Console.WriteLine("Press [D] Discover a new location\nPress [S] Show your current location \nPress [A] Attack a monster\nPress [V] View the inventory\nPress [Q] Quit the game");

                string playerChoice = Console.ReadLine().ToUpper();

                switch (playerChoice)
                {
                    case "D":
                        DiscoverLocation();
                        break;
                    case "A":
                        AttackMonster();
                        break;
                    case "V":
                        ViewInventory();
                        break;
                    case "S":
                        DisplayLocation();
                        break;
                    case "Q":
                        isStartPlay = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice, Please try again");
                        break;
                }
            }
        }

        // Choose Location
        public void DiscoverLocation()
        {
            bool display = true;
            while (display)
            {
                Console.WriteLine("Press[F] to discover Forest\nPress[C] to discover Cave\nPress[T] to discover Tower\nPress[Q] Quit");

                string playerDiscover = Console.ReadLine().ToUpper();
                switch (playerDiscover)
                {
                    case "F":
                        chosenLocation = "Forest";
                        DisplayLocation();
                        display = false;
                        break;
                    case "C":
                        chosenLocation = "Cave";
                        DisplayLocation();
                        display = false;
                        break;
                    case "T":
                        chosenLocation = "Tower";
                        DisplayLocation();
                        display = false;
                        break;
                    case "Q":
                        display=false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice, Please try again");
                        break;
                }
            }
        }

        // Display Location
        public void DisplayLocation()
        {
            Console.WriteLine($"Your Location: {chosenLocation}");
        }

        // Monster list
        public void chosenMonster()
        {
            monster = new List<Monster>
            {
                new RegularMonster("Mike Wazowski", 80, 70, 60),
                new RegularMonster("Boo", 60, 30, 20),
                new RegularMonster("Rex", 90, 60, 65),
                new BossMonster() 
            };
        }

        public void AttackMonster()
        {
            
          if (monster == null || monster.Count == 0)
          {
             Console.WriteLine("No monsters available to attack.");
              return;
          }

            Monster enemy = monster[random.Next(monster.Count)];
            Console.WriteLine($"A wild {enemy.Name} appears!");

            bool isPlayerWin = battleSystem.StartBattle(player, enemy);

            if (isPlayerWin)
            {
                Console.WriteLine($"You defeated the {enemy.Name}!");
            }
            else
            {
                Console.WriteLine("You have been defeated...");
            }
        }

        public void ViewInventory()
        {
            
            bool areThereItems=player.Inventory.DisplayTheInventory();

            if (areThereItems)
            {
                Console.WriteLine("Do you want to use an item? (yes/no)");
                string useItemChoice = Console.ReadLine().ToLower();

                if (useItemChoice == "yes")
                {
                    Console.WriteLine("Enter the name of the item you want to use:");
                    string itemName = Console.ReadLine();
                    Console.WriteLine($"you are in view method{itemName}");
                    //player.UseItem(itemName);
                }
            }
        }
    }
}
