using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Adventure_Quest_RPG
{

    public class Player:Character
    {
        //Random random = new Random();
        public Player( string name  , int attackPower = 60) {

            Name = name;
            Health = 100;
            AttackPower = attackPower;
            Defense = 18;
            Inventory = new Inventory();

        }

        public void UseItem(string itemName)
        {
            foreach (var invItem in Inventory())
            {
                if (invItem.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    item = invItem;
                    break; // Exit the loop once the item is found
                }
            }

            if (item != null)
            {
                // Use the item
                item.Use(this); // Pass 'this' to apply effects to the player

                // Remove the item from inventory after use (optional, depends on your game logic)
                Inventory.Remove(item);

                Console.WriteLine($"Used {itemName}."); // Confirmation message
            }
            else
            {
                Console.WriteLine($"Item {itemName} not found in inventory.");
            }
        }


    }
}
