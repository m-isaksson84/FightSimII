using System;

namespace FightSimII
{
    public class Fighter
    {
        public int health = 100;

        public Weapon weapon = new Weapon();

        public void Attack(Fighter target)
        {
            //tar 100 - 5 (fixa)
            target.health -= weapon.swordDamage;
        }

        public void HealthPlayer1()
        {


        }

        public void AttackFromPlayer1()
        {

        }

        public void AttackFromPlayer2()
        {

        }

        public bool GetAlive()
        {
            if (health > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}