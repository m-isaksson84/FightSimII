using System;

namespace FightSimII
{
    public class Weapon
    {
        public int spearDamage = 3;
        public int swordDamage = 5;
        public int swordDamageMultiplier;
        public int spearDamageMultiplier;
        public int swordDmg;
        public int spearDmg;

        Random generator = new Random();

        public Weapon()
        {

            //swordDamageMultiplier = generator.Next(1, 5);
            //swordDmg = swordDamage * swordDamageMultiplier;
        }


        public void Sword()
        {
            swordDamageMultiplier = generator.Next(1, 5);
            swordDmg = swordDamage * swordDamageMultiplier;
        }

        public void Spear()
        {
            spearDamageMultiplier = generator.Next(1, 10);
            spearDmg = spearDamage * spearDamageMultiplier;
        }

    }
}