using System;

namespace FightSimII
{
    class Program
    {
        static void Main(string[] args)
        {

            Fighter fighter1 = new Fighter();
            Fighter fighter2 = new Fighter();
            Weapon weapon = new Weapon();

            while (fighter1.GetAlive() && fighter2.GetAlive())
            {

                weapon.Spear();
                weapon.Sword();

                fighter1.Attack(fighter2);
                fighter1.Attack(fighter1);


                Console.WriteLine("health:" + fighter1.health);
                Console.WriteLine("health:" + fighter2.health);

                //skriver swordDmg och spearDmg
                Console.WriteLine(weapon.swordDmg);
                Console.WriteLine(weapon.spearDmg);
                Console.ReadLine();

                //fighter2.HealthPlayer1();
            }
        }
    }
}
