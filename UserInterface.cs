using Dnd__Combat.DAOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd__Combat
{
    public class UserInterface
    {
        private readonly DiceManager diceManager;
        public UserInterface(DiceManager dm)
        {
            this.diceManager = dm;
        }


        // methods

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to DnD Combat Simulator!");
            Console.WriteLine();
        }

        public void MainMenu()
        {
            bool done = false;
            while (!done)
            {

                CharacterDAO characterDAO = new CharacterDAO("conn string here", diceManager); // connection string here when in database
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("1) Create a new character");
                Console.WriteLine("2) Battle 2 characters once");
                Console.WriteLine("3) Battle 2 characters multiple times");
                Console.WriteLine("4) Battle 2 characters for a certain amount of time");
                Console.WriteLine("5) Allow the database to randomly generate fights for a certain amount of time");
                Console.WriteLine("6) View stats of a certain character");
                Console.WriteLine("0) Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Would you like to randomly generate a character? Y/N");
                        string userInput = Console.ReadLine();
                        if (userInput.ToLower() == "y")
                        {

                            Character character = characterDAO.CreateCharacterRandomly();
                            Console.WriteLine("Here are your new character's stats!");
                            Console.WriteLine("Strength: " + character.Strength);
                            Console.WriteLine("Dexterity " + character.Dexterity);
                            Console.WriteLine("Constitution: " + character.Constitution);
                            Console.WriteLine("Intelligence: " + character.Intelligence);
                            Console.WriteLine("Wisdom: " + character.Wisdom);
                            Console.WriteLine("Charisma: " + character.Charisma);


                        }
                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    case "5":

                        break;

                    case "6":

                        break;

                    case "0":
                        Console.WriteLine("Goodbye!");
                        done = true;
                        break;
                }
            }
        }
        //public Character CharacterPicker ()
        //public void RandomCharacterMaker()
        //{
        //    Console.WriteLine("Would you like to make a new, randomized character?");
        //    string answer = Console.ReadLine();

        //    Character randomlyMade = new Character();

        //    if (answer == "Y"|| answer == "y")
        //    {
        //        randomlyMade.CreateCharacter();
        //    }
        //}

        public void CharacterCombat()
        {
            //Console.WriteLine("Welcome to DnD Combat Simulator!");
            //Console.WriteLine();
            Console.WriteLine("Please pick 2 characters to fight each other! You can choose Bob, Joe, or Sally!");

            Random rnd = new Random();

            //need to instantiate instance of dice class here? Not at this time



            //Weapons
            Weapon shortSword = new Weapon();
            shortSword.Name = "sword";
            shortSword.DamageMax = 6;

            Weapon handAxe = new Weapon();
            handAxe.Name = "handaxe";
            handAxe.DamageMax = 6;

            Weapon greatClub = new Weapon();
            greatClub.Name = "greatclub";
            greatClub.DamageMax = 8;

            Weapon greatSword = new Weapon();
            greatSword.Name = "greatsword";
            greatSword.DamageMax = 6;
            greatSword.NumberOfDice = 2;

            // if I make the type of weapon a class, I can add  +1, +2 , etc. weapons and also have special magical weapons of a particular type
            // can make an Attack interface if I want to add spells, needs an attack method and min and max damage and mayber # of dice?

            // if i can add # of dice, I can make it so that fireball does 6d6 damage or whatever and a greatsword can do 2d6
            // Its not a huge difference, but there is a difference in probability for  2d6 vs like 1d12. Hence adding number of dice Property

            //Characters
            Character bob = new Character();
            bob.Name = "Bob";
            bob.Weapon = shortSword;
            bob.HealthPoints = 50;
            bob.DexBonus = 2;



            Character joe = new Character();
            joe.Name = "Joe";
            joe.Weapon = handAxe;
            joe.HealthPoints = 50;
            joe.DexBonus = 3;



            Character sally = new Character();
            sally.Name = "Sally";
            sally.Weapon = greatClub;
            sally.HealthPoints = 50;
            sally.DexBonus = 1;


            // Combat
            Combat combat = new Combat();


            //Menu to pick characters. How do I put this in a class that can see the characters made??
            Console.WriteLine("Who do you pick first?");
            string first = Console.ReadLine();

            Character a = null;
            if (first == bob.Name)
            {
                a = bob;
            }
            else if (first == joe.Name)
            {
                a = joe;
            }
            else
            {
                a = sally;
            }

            Console.WriteLine("Great! Who do you pick second?");
            string second = Console.ReadLine();

            Character b = null;
            if (second == bob.Name)
            {
                b = bob;
            }
            else if (second == joe.Name)
            {
                b = joe;
            }
            else
            {
                b = sally;
            }


            Console.WriteLine("Perfect! Let the fight begin!!!");
            Console.WriteLine();

            //combat.TwoPersonMelee(a, b);





        }
    }
}
