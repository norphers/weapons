using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6.Weapons
{
    class GuidedMissiles : ITankWeapons
    {
        public void Hit(string target)
        {
            Console.WriteLine("Target selected. {0} had been eliminated.", target);
        }

    }
}
