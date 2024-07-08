using System;
using System.Collections.Generic;

namespace Adventure_Quest_RPG
{
    public class Adventure
    {

        public List<Monster> monster;
        public Random random = new Random();
        Player player = new Player("player");
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
                if (level >= 10)
                {
                    Console.WriteLine("\nThe victory wasn't easy, but we earned it with honor.\n");
                    isStartPlay = false;
                    
                    return;
                }
                Console.WriteLine("Press [D] Discover a new location\nPress [S] Show your current location \nPress [A] Attack a monster\nPress [V] View the inventory\nPress [Q] Quit the game");

                string playerChoice = Console.ReadLine().ToUpper();

                switch (playerChoice)
                {
                    case "D":
                        DiscoverLocation();
                        break;
                    case "A":
                     
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
                Console.WriteLine("Press[F] to discover The Forest\nPress[C] to discover City of Walls\nPress[T] to discover The Mountain\nPress[Q] Quit");

                string playerDiscover = Console.ReadLine().ToUpper();
                switch (playerDiscover)
                {
                    case "F":
                        Console.ForegroundColor = ConsoleColor.Green;
                        chosenLocation = " The Forest";
                        DisplayLocation();
                        display = false;
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        chosenLocation = "City of walls";
                        DisplayLocation();
                        display = false;
                        break;
                    case "T":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        chosenLocation = "The Mountain";
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
            new RegularMonster("Cart Titan", 60, 10, 25),
new RegularMonster("Jaw Titan", 80, 15, 15),
new RegularMonster("Female Titan", 100, 30, 30),
new RegularMonster("Armored  Titan", 100, 35, 40),
new RegularMonster("Beast Titan", 100, 40, 35),
new RegularMonster("War Hammer Titan", 100, 45, 45),
new RegularMonster("Colossal Titan", 100, 50, 50),
new RegularMonster("Attack Titan", 100, 60, 55),
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
     
            Monster enemy = monster[level-1];



            Console.WriteLine($"\t\t\t ------------------ Level :{level} - location :{chosenLocation}----------------\n");
level++;
            bool isPlayerWin = battleSystem.StartBattle(player, enemy); 

            if (isPlayerWin)
            {
                
                Console.WriteLine($"You defeated the {enemy.Name}!\n");
                Console.WriteLine("################################");
            }
            else
            {
                
                Console.WriteLine("You have been defeated...");
                Console.WriteLine("################################");
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
