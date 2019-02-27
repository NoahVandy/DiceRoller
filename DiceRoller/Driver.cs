using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Driver
    {
        static void Main(string[] args)
        {
            Dice d1 = new Dice(6);

            Dice d2 = new Dice(6);
            d1.rollDice();

            d2.rollDice();


        }
    }
}
