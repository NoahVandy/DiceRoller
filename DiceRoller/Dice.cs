using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Dice
    {
        private int numberOfSides;
        static Random rng = new Random();

        public Dice(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
        }

        public int getNumberOfSides()
        {
            return this.numberOfSides;
        }

        public int rollDice()
        {
            
            return rng.Next(1 , numberOfSides);
        }
    }
}
