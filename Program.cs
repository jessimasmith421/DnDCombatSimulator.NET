using System;

namespace Dnd__Combat
{
    class Program
    {
        static void Main(string[] args) // PUT ALL CODE IN HERE!!! (Main method)
        {
            UserInterface menu = new UserInterface();
            DiceManager maker = new DiceManager();

            menu.WelcomeMessage();

            menu.RandomCharacterMaker();
            //menu.CharacterCombat();


            //maker.CharacterStats();


        }
    }
}
