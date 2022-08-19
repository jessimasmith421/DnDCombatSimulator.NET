using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd__Combat
{
    public class Combat
    {
        //Methods
        public void BasicCombatTest(Character a, Character b)
        {
            while (a.HealthPoints > 0 && b.HealthPoints > 0)
            {
                int bDamage = b.Weapon.Damage();
                a.HealthPoints -= bDamage;
                Console.WriteLine(b.Name + " hit " + a.Name + " for " + bDamage + ". " + a.Name + " has " + a.HealthPoints + " hp left.");
                int aDamage = a.Weapon.Damage();
                b.HealthPoints -= aDamage;
                Console.WriteLine(a.Name + " hit " + b.Name + " for " + aDamage + ". " + b.Name + " has " + b.HealthPoints + " hp left.");
                Console.WriteLine();
            }
        }
        //public void TwoPersonMelee(Character a, Character b)
        //{
        //    a.InitiativeRoll();
        //    b.InitiativeRoll();

        //    if (a.Initiative > b.Initiative)
        //    {
        //        Console.WriteLine(a.Name + " rolled higher than " + b.Name + ", so " + a.Name + " goes first!");
        //        Console.WriteLine();
        //        while (a.HealthPoints > 0 && b.HealthPoints > 0)
        //        {
        //            //a attacks first

        //            a.AttackRoll(b);
        //            b.AttackRoll(a);

        //        }
        //        if (a.HealthPoints > 0)
        //        {
        //            Console.WriteLine(a.Name + " wins!!!");
        //        }
        //        else
        //        {
        //            Console.WriteLine(b.Name + " wins!!!");
        //        }
        //    }
        //    else if (b.Initiative > a.Initiative)
        //    {
        //        Console.WriteLine(b.Name + " rolled higher than " + a.Name + ", so " + b.Name + " goes first!");
        //        Console.WriteLine();
        //        while (a.HealthPoints > 0 && b.HealthPoints > 0)
        //        {
        //            //a attacks first

        //            b.AttackRoll(a);
        //            a.AttackRoll(b);

        //        }
        //        if (a.HealthPoints > 0)
        //        {
        //            Console.WriteLine(a.Name + " wins!!!");
        //        }
        //        else
        //        {
        //            Console.WriteLine(b.Name + " wins!!!");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("same initiative lol try again!");
        //    }

        //}
    }
}
