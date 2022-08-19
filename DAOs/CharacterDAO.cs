using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd__Combat.DAOs
{
    public class CharacterDAO :ICharacterDAO
    {
        private readonly string connectionString;
        private DiceManager DiceManager;
         
        public CharacterDAO(string connStr, DiceManager diceManager)
        {
            this.connectionString = connStr;
            this.DiceManager = diceManager;
        }
        //methods
        public void InitiativeRoll(Character character)
        {
            character.Initiative = DiceManager.DiceRoll(1, 20) + character.DexBonus;
            Console.WriteLine(character.Name + " rolled a " + character.Initiative + " for initiative.");
            //Console.WriteLine();
        }

        public void AttackRoll(Character attacking, Character beingAttacked)
        {
            if (attacking.HealthPoints > 0)
            {
                int rollToHit = DiceManager.DiceRoll(1, 20);
                Console.Write(attacking.Name + " rolled a " + rollToHit + " to hit! ");
                if (rollToHit >= beingAttacked.ArmorClass && attacking.HealthPoints > 0)
                {
                    int damage = attacking.Weapon.Damage();
                    beingAttacked.HealthPoints -= damage;
                    Console.WriteLine(attacking.Name + " hit " + beingAttacked.Name + " for " + damage + ". " + beingAttacked.Name + " has " + beingAttacked.HealthPoints + " hp left.");
                }
                else
                {
                    Console.WriteLine(attacking.Name + " missed " + beingAttacked.Name + "!!!");
                }
            }
            else
            {
                Console.WriteLine(attacking.Name + " is down!!!");
            }
            Console.WriteLine();
        }


        // CREATES A CHARACTER WITH RANDOM STATS!!!!
        public Character CreateCharacterRandomly()
        {
            // run dice.CharacterStats() 6 times to get strength, dex, int, wis, cha, and con

            Character newCharacter = new Character();

            newCharacter.Strength = DiceManager.CharacterStats();

            newCharacter.Dexterity = DiceManager.CharacterStats();

            newCharacter.Constitution = DiceManager.CharacterStats();

            newCharacter.Intelligence = DiceManager.CharacterStats();

            newCharacter.Wisdom = DiceManager.CharacterStats();

            newCharacter.Charisma = DiceManager.CharacterStats();

            return newCharacter;

        }
    }
}
