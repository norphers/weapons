using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6.Weapons
{
    class TankGun : ITankWeapons
    {
        public void Hit(string target)
        {
            Console.WriteLine("{0} had been erased.", target);
        }

    }
}
