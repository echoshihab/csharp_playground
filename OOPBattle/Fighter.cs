using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBattle
{
    class Fighter
    {
        public string Name { get; set; } = "Fighter";
        public double Health { get; set; } = 0;
        public double AttakMax { get; set; } = 0;

        public double BlockMax { get; set; } = 0;

        //random numbers
        Random rndValue = new Random();

        public Fighter(string name = "Fighter", double health = 0, double attkMax = 0, double blockMAx = 0)

        {
            Name = name;
            Health = health;
            AttakMax = attkMax;
            BlockMax = blockMAx;
        }

        public double Attack()
        {
            return rndValue.Next(1, (int)AttakMax);
        }


        public double Block()
        {
            return rndValue.Next(1, (int)BlockMax);
        }
    }

}