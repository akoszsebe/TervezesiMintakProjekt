using Project.WeaponDecorator;
using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Armory irak = new Armory();
            irak.AddWeapon(new BaseWeapon(EWeaponTypes.Submachine_gun));
            irak.AddWeapon(new SuppressorForWeapon(new BaseWeapon(EWeaponTypes.Sniper)));
            irak.AddWeapon(new SideSaddlesForWeapon(new BaseWeapon(EWeaponTypes.Shotgun)));

            irak.stock.ForEach(x => { x.Aim_And_Fire(); Console.WriteLine("---"); });
        }
    }
}
