using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd__Combat
{
    public class Character
    {
        // instantiation of DiceManager Class
        DiceManager dice = new DiceManager();

        //properties
        public string Name { get; set; }
        public int Level { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int DexBonus { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public Weapon Weapon { get; set; }
        public int HealthPoints { get; set; }
      
        public int ArmorClass
        {
            get
            {
                int armorClass = 10 + DexBonus;
                return armorClass;
            }
        }
        public int Initiative { get; set; }
        //public int DexBonus { get; set; }
        //public int DexBonus { get; set; }


        ////methods
        //public void InitiativeRoll()
        //{
        //    Initiative = dice.DiceRoll(1, 20) + DexBonus;
        //    Console.WriteLine(Name + " rolled a " + Initiative + " for initiative.");
        //    //Console.WriteLine();
        //}

        //public void AttackRoll(Character beingAttacked)
        //{
        //    if (HealthPoints > 0)
        //    {
        //        int rollToHit = dice.DiceRoll(1, 20);
        //        Console.Write(Name + " rolled a " + rollToHit + " to hit! ");
        //        if (rollToHit >= beingAttacked.ArmorClass && HealthPoints > 0)
        //        {
        //            int damage = Weapon.Damage();
        //            beingAttacked.HealthPoints -= damage;
        //            Console.WriteLine(Name + " hit " + beingAttacked.Name + " for " + damage + ". " + beingAttacked.Name + " has " + beingAttacked.HealthPoints + " hp left.");
        //        }
        //        else
        //        {
        //            Console.WriteLine(Name + " missed " + beingAttacked.Name + "!!!");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(Name + " is down!!!");
        //    }
        //    Console.WriteLine();
        //}


        //// CREATES A CHARACTER WITH RANDOM STATS!!!!
        //public Character CreateCharacter()
        //{
        //    // run dice.CharacterStats() 6 times to get strength, dex, int, wis, cha, and con

        //    Character newCharacter = new Character();

        //    newCharacter.Strength = dice.CharacterStats();
           
        //    newCharacter.Dexterity = dice.CharacterStats();

        //    newCharacter.Constitution = dice.CharacterStats();
            
        //    newCharacter.Intelligence = dice.CharacterStats();
          
        //    newCharacter.Wisdom= dice.CharacterStats();
            
        //    newCharacter.Charisma = dice.CharacterStats();

        //    return newCharacter;

        //}

        

    }
}
