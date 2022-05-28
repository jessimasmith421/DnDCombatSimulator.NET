using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd__Combat
{
    public class Weapon 
    {


        // instantiation of DiceManager Class
        DiceManager dice = new DiceManager();

        //properties
        public string Name { get; set; }
        public int DamageMin { get; set; } =1;
        public int DamageMax { get; set; }

        //methods
        public int Damage()
        {
            int damage = dice.DiceRoll(DamageMin, DamageMax);
            return damage;
        }
    }
}
