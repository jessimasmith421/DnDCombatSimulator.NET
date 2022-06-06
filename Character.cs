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
        public Weapon Weapon { get; set; }
        public int HealthPoints { get; set; }
        //public int ArmorClass { get; set; } // at some point, make this derived from dex bonus
        public int ArmorClass
        {
            get
            {
                int armorClass = 10 + DexBonus;
                return armorClass;
            }
        }
        public int Initiative { get; private set; }
        public int DexBonus { get; set; }

        //methods
        public void InitiativeRoll()
        {
            Initiative = dice.DiceRoll(1, 20) + DexBonus;
            Console.WriteLine(Name + " rolled a " + Initiative + " for initiative.");
            //Console.WriteLine();
        }

        public void AttackRoll(Character beingAttacked)
        {
            if (HealthPoints > 0)
            {
                int rollToHit = dice.DiceRoll(1, 20);
                Console.Write(Name + " rolled a " + rollToHit + " to hit! ");
                if (rollToHit >= beingAttacked.ArmorClass && HealthPoints > 0)
                {
                    int damage = Weapon.Damage();
                    beingAttacked.HealthPoints -= damage;
                    Console.WriteLine(Name + " hit " + beingAttacked.Name + " for " + damage + ". " + beingAttacked.Name + " has " + beingAttacked.HealthPoints + " hp left.");
                }
                else
                {
                    Console.WriteLine(Name + " missed " + beingAttacked.Name + "!!!");
                }
            }
            else
            {
                Console.WriteLine(Name + " is down!!!");
            }
            Console.WriteLine();
        }


        // CREATES A CHARACTER WITH RANDOM STATS!!!!
        public void CreateCharacter()
        {
            // run dice.CharacterStats() 6 times to get strength, dex, int, wis, cha, and con
            // maybe put it all in a dictionary? until we put it in a character

            Dictionary<string, int> characterStats = new Dictionary<string, int>();

            characterStats["Strength"] = dice.CharacterStats();
            Console.WriteLine("Strength: " + characterStats["Strength"]);
            
            characterStats["Dexterity"] = dice.CharacterStats();
            Console.WriteLine("Dexterity: " + characterStats["Dexterity"]);
            
            characterStats["Constitution"] = dice.CharacterStats();
            Console.WriteLine("Constitution: " + characterStats["Constitution"]);
            
            characterStats["Intelligence"] = dice.CharacterStats();
            Console.WriteLine("Intelligence: " + characterStats["Intelligence"]);
            
            characterStats["Wisdom"] = dice.CharacterStats();
            Console.WriteLine("Wisdom " + characterStats["Wisdom"]);
            
            characterStats["Charisma"] = dice.CharacterStats();
            Console.WriteLine("Charisma: " + characterStats["Charisma"]);

        }

    }
}
