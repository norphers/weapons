using ConsoleApp6.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class ModernSoldier
    {
        private ISoldierWeapons weapon;

        public ModernSoldier(ISoldierWeapons weapon)
        {
            this.weapon = weapon;
        }

        public void ChangeWeapon(ISoldierWeapons weapon)
        {
            this.weapon = weapon;
        } 

        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }

    }
}
