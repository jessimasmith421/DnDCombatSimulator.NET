using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd__Combat
{
    public class DiceManager
    {

        Random rnd = new Random();
        public int DiceRoll(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }

        public int MultipleDiceRoll(int minOnDie, int maxOnDie, int numberOfDice)
        {
            int totalRoll = 0;
            for (int i = 1; i <= numberOfDice; i++)
            {
                int numOnDie = DiceRoll(minOnDie, maxOnDie);
                totalRoll += numOnDie;

                Console.WriteLine("Die #" + i + " is " + numOnDie);
            }
            return totalRoll;
        }
    }
}
