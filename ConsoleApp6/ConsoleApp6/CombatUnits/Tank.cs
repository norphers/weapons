using ConsoleApp6.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Tank
    {
        private ITankWeapons weapon;
        public Tank(ITankWeapons weapon)
        {
            this.weapon = weapon;
        }
        public void ChangeWeapon(ITankWeapons weapon)
        {
            this.weapon = weapon;
        }
        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
    }
}
