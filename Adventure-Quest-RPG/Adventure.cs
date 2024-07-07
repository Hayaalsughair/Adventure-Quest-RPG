using System;
using System.Collections.Generic;

namespace Adventure_Quest_RPG
{
    public class Adventure
    {

        public List<Monster> monster;
        public Random random = new Random();
        public Player player = new Player("shalaby");
        public string chosenLocation = "Lobby";
        public BattleSystem battleSystem = new BattleSystem();
        public int level = 1;
        public bool isStartPlay = true;


        public Adventure()
        {
            chosenMonster();
        }

        public void StartAdventure()
        {

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
                      Console.WriteLine($"Level: {level}");
                        choseItems();
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
                        display = false;
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
            new RegularMonster("Attack Titan", 100, 50, 20),
            new RegularMonster("Colossal Titan", 100, 50, 20),
            new RegularMonster("Armored Titan", 100, 50, 20),
            new RegularMonster("Female Titan", 100, 50, 20),
            new RegularMonster("Beast Titan", 100, 50, 20),
            new RegularMonster("Jaw Titan", 100, 50, 20),
            new RegularMonster("Cart Titan", 100, 50, 20),
            new RegularMonster("War Hammer Titan", 100, 50, 20),
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

            if (level > 9)
            {
                isStartPlay = false;
                return;
            }
            level++;

            Monster enemy = monster[level-1];
            Console.WriteLine($"A wild {enemy.Name} appears!");

            bool isPlayerWin = battleSystem.StartBattle(player, enemy);

            if (isPlayerWin)
            {
                Console.WriteLine($"You defeated the {enemy.Name}!\n");
            }
            else
            {
              Console.WriteLine("You have been defeated...");
            }
        }

        public void ViewInventory()
        {

            string isEmpty = player.Inventory.DisplayTheInventory();
            if(isEmpty != "")
            {
                Console.WriteLine(isEmpty);
            }


        }


        public void choseItems()
        {

            string isEmpty = player.Inventory.DisplayTheInventory();
            if (isEmpty=="")
            {
                Console.WriteLine("Do you want to use an item? (yes/no)");
                string useItemChoice = Console.ReadLine().ToLower();

                if (useItemChoice == "yes")
                {
                    Console.WriteLine("Enter the item numer you want to use:");
                    int itemIndex = -1 ;
                    try
                    {
                        itemIndex = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid integer.");
                    }
                    Items item = player.Inventory.GetItemByIndex(itemIndex - 1);
                    if (item != null)
                    {
                        player.UseItem(item);
                        Console.WriteLine($"{item.Name} used.");
                        Console.WriteLine(item.Description);
                    }
                    else
                    {
                        Console.WriteLine("Invalid item selection.");
                    }
                }
               
            }
        }       


    }
}
