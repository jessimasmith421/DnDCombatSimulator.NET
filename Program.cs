using System;

namespace Dnd__Combat
{
    class Program
    {
        static void Main(string[] args) // PUT ALL CODE IN HERE!!! (Main method)
        {
            DiceManager maker = new DiceManager();
            UserInterface menu = new UserInterface(maker);

            // MAKE MENUS while loops that don't stop until bool done = true!!! (like in capstone!!)

            menu.WelcomeMessage();
            menu.MainMenu();

            //menu.RandomCharacterMaker();
            //menu.CharacterCombat();


            //maker.CharacterStats();


        }
    }
}
