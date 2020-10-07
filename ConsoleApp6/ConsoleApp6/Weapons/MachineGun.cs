using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6.Weapons
{
    class MachineGun : ISoldierWeapons
    {
        public void Hit(string target)
        {
            Console.WriteLine("You've turned {0} into a strainer.", target);
        }

    }
}
