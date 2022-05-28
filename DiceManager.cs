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
    }
}
