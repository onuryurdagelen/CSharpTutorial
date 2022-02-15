using System;
using System.Collections.Generic;
using System.Text;

namespace KurtAdamSaldirisiOrnek
{
    public class Account
    {
        public string userName { get; set; }
        public string ethnicity { get; set; }
        public string major { get; set; }
        public string weapon { get; set; }
        public int damage { get; set; }

        Random random = new Random();
        public void Attack()
        {
            damage = 0;
           
            /*
             irk => human= +5,monster + 10;
            warrior => 40,
            mage => 30-50
            assassin => 10-70;
            Archer => 5-60;

            Warrior
             Mage
             Archer
            Assassin
             */
            if (ethnicity == "Human")
            {
                damage += 5;
            }
            else
            {
                damage += 10;
            }
            switch (major)
            {
                case "Warrior":
                    damage += 40;
                    break;
                case "Mage":
                    damage += random.Next(30, 51);
                    break;
                case "Assassin":
                    damage += random.Next(10, 71);
                    break;
                case "Archer":
                    damage += random.Next(5, 61);
                    break;
                default:
                    break;
            }
           
        }
        

    }
}
