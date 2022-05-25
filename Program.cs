using System;

namespace Dnd__Combat
{
    class Program
    {
        static void Main(string[] args) // PUT ALL CODE IN HERE!!! (Main method)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to DnD Combat!");

            Random rnd = new Random();
            

            int DiceRoll(int min, int max)
            {
                return rnd.Next(min, max + 1);                
            }
            
            
            Weapon shortSword = new Weapon();
            shortSword.Name = "sword";
            shortSword.DamageMin = 1;
            shortSword.DamageMax = 6;

            Character bob = new Character();
            bob.Name = "Bob";
            bob.Weapon = shortSword;
            bob.HealthPoints = 50;
            

            
            
            while (bob.HealthPoints > 0)
            {
                bob.HealthPoints -= DiceRoll(shortSword.DamageMin, shortSword.DamageMax);
                Console.WriteLine("Ouchie! " + bob.HealthPoints);
            }
            

        }
    }
}
