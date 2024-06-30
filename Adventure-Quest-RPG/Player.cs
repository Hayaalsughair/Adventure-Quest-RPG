using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Adventure_Quest_RPG
{
    public class Player:Character
    {
        public Player( string name ) {

            Name = name;
            Health = 100;
            AttackPower = 10;
            Defense = 20;
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"player Name: {Name} Health:{Health} AttackPower: {AttackPower} Defense:{Defense}");
        }
        public void SolveDamge()
        {
            Health = Health - Math.Max(damage - Defense, 0);
        }





    }
}
