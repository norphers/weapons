using ConsoleApp6.Weapons;
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tutorial();
            //ModernSoldiers();
            Tanks();
        }

        static void Tutorial()
        {
            var warrior1 = new Samurai(new Sword());
            var warrior2 = new Samurai(new Shuriken());
            warrior1.Attack("the evildoers");
            warrior2.Attack("the evildoers");
        }

        static void ModernSoldiers()
        {
            var warrior3 = new ModernSoldier(new MachineGun());
            warrior3.Attack("the evildoers");
            warrior3.ChangeWeapon(new Sniper());
            warrior3.Attack("the evildoers");
        }

        static void Tanks()
        {
            var warrior4 = new Tank(new TankGun());
            warrior4.Attack("the evildoers");
            warrior4.ChangeWeapon(new HEAT());
            warrior4.Attack("the evildoers");
            warrior4.ChangeWeapon(new GuidedMissiles());
            warrior4.Attack("the evildoers");
        }
    }
}
