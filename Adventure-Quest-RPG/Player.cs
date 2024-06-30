﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }

        public Player( string name ) {

            Name = name;
            Health = 100;
            AttackPower = 10;
            Defense = 20;
        }
    }
}
