using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Sword : ISamurayWeapons
    {
        public void Hit(string target)
        {
            Console.WriteLine("Chooped {0} clean in half.", target);
        }
    }
}
