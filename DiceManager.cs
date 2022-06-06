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

        public int CharacterStats()
        {
            List<int> statsRoll = new List<int>();

            for(int i = 0; i <4; i++) // for loop to roll 4 dice
            {
                int roll = rnd.Next(1, 7); // range is 1-7 because .Next makes the max number exculsive (,6 instead of <=6)
                statsRoll.Add(roll);
            }
            statsRoll.Sort();
            statsRoll.RemoveAt(0);

            int total = 0;

            for(int i = 0; i < 3; i++)
            {
                total += statsRoll[i];
            }
            return total;
        }
    }
}
