using System;

namespace Dnd__Combat
{
    class Program
    {
        static void Main(string[] args) // PUT ALL CODE IN HERE!!! (Main method)
        {

            Console.WriteLine("Welcome to DnD Combat Simulator!");
            Console.WriteLine();
            Console.WriteLine("Please pick 2 characters to fight each other! You can choose Bob, Joe, or Sally!");

            Random rnd = new Random();

            //need to instantiate instance of dice class



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

            combat.TwoPersonMelee(a, b);


        }
    }
}
