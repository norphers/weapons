using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6.Weapons
{
    class HEAT : ITankWeapons
    {
        //high explosive anti-tank
        public void Hit(string target)
        {
            Console.WriteLine("{0} have exploted.", target);
        }
    }
}
