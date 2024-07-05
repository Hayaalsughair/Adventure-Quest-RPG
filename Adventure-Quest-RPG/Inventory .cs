﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class Inventory
    {
        List<Items> items;

        public Inventory() { 
        items = new List<Items>();
        }

        public void AddItem(Items item) { 
        
            items.Add(item);
        }

       public void DisplayTheInventory() {

            Console.WriteLine("you have this items in your inventory");
            foreach (var item in items)
            {
                Console.WriteLine($"Item Name: {item.Name} \n Description: {item.Description}\n");
            }

        }
    }
}