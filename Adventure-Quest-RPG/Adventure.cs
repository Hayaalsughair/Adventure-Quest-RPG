using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class Adventure
    {
        private List<string> locations;
        private List<string> monster;

        private string chosenLocation = "Lobby ";

        public void StartAdventure()
        {
            bool isStartPlay = true ;

            while (true)
            {
                Console.WriteLine("Press [D] Discover a new location\nPress [S] Show your current location \nPress [A] Attack a monster\nPress [V] View the inventory\nPress [Q] Quit the game");

               
               string playerChoice =  Console.ReadLine().ToUpper();
   
                switch (playerChoice)
                {

                    case "D":
                        DiscoverLocation();
                        break;
                    case "A":

                        break;
                    case "V":


                        break;
                    case "S":
                        DisplayLocation();
                        break;
                    case "Q":
                        isStartPlay = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice,Please try again");
                        break;
                }
            }
        }






        //Choose Location
        public void DiscoverLocation()
        {
            Console.WriteLine("Press[F] to dicover Forest\nPress[C] to dicover Cave\nPress [T] to dicover Tower");
            bool display = true;
            while (display)
            {
             string playerDicover = Console.ReadLine().ToUpper();
                switch (playerDicover)
                {
                    case "F":
                        Console.WriteLine($"You discover a new location: {locations[0]}");
                        chosenLocation = locations[0];
                          break;
                    case "C":
                        Console.WriteLine($"You discover a new location: {locations[1]}");
                        chosenLocation = locations[1];

                        break;
                    case "T":
                        Console.WriteLine($"You discover a new location: {locations[2]}");
                        chosenLocation = locations[2];

                        break;
                    default:
                        Console.WriteLine("Invalid Choice,Please try again");
                        break;
                }

            }

        }

        //Display Location 
        public void DisplayLocation()
        {
            Console.WriteLine($"Your Location: {chosenLocation}");
        }
        //Location list
        public void Gamelocations()
        {
            locations = new List<string>
            {
                "Forest",
                "Cave",
                "Tower"
            };
        }



    }
}




