using System;

namespace Dnd__Combat
{
    class Program
    {
        static void Main(string[] args) // PUT ALL CODE IN HERE!!! (Main method)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to DnD Combat!");
            Console.WriteLine();

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

            combat.TwoPersonMelee(joe, sally);


        }
    }
}
