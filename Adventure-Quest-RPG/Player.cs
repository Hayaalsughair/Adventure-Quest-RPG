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
        //Random random = new Random();
        public Player( string name  , int attackPower = 60) {

            Name = name;
            Health = 100;
            AttackPower = attackPower;
            Defense = 18; 
        }

        
    }
}
