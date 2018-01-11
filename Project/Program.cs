using Project.BattleFieldFactorys;
using Project.GameLogic;
using Project.Iterators;
using Project.SoldierBehaviors;
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
            irak.AddWeapon(new BaseWeapon(EWeaponTypes.Sniper));
            irak.AddWeapon(new BaseWeapon(EWeaponTypes.Shotgun));
            irak.AddWeapon(new BaseWeapon(EWeaponTypes.Machine_gun));
            irak.AddWeapon(new BaseWeapon(EWeaponTypes.Marksman));
            Console.WriteLine(" Armory ");
            irak.stock.ForEach(x => { x.Aim_And_Fire(); });

            Console.WriteLine("  ----$$$--- ");
            MyCollection natziSoldiers = new MyCollection();
            natziSoldiers[0] = new Item(new AirforceSoldierBehavior(new BaseWeapon(EWeaponTypes.Submachine_gun)));
            natziSoldiers[1] = new Item(new GroundforcesSoldierBehavior(new SuppressorForWeapon(new SuppressorForWeapon(new BaseWeapon(EWeaponTypes.Marksman)))));
            natziSoldiers[2] = new Item(new GroundforcesSoldierBehavior(new SideSaddlesForWeapon(new BaseWeapon(EWeaponTypes.Shotgun))));

            Console.WriteLine("     Iterating over NatziSoldiers:");
            Printer.Print(natziSoldiers);

            MyCollection redSoldiers = new MyCollection();
            redSoldiers[0] = new Item(new GroundforcesSoldierBehavior(new BaseWeapon(EWeaponTypes.Marksman)));
            redSoldiers[1] = new Item(new GroundforcesSoldierBehavior(new SuppressorForWeapon(new SuppressorForWeapon(new BaseWeapon(EWeaponTypes.Marksman)))));
            redSoldiers[2] = new Item(new AirforceSoldierBehavior(new SideSaddlesForWeapon(new BaseWeapon(EWeaponTypes.Shotgun))));
            redSoldiers[3] = new Item(new GroundforcesSoldierBehavior(new SideSaddlesForWeapon(new BaseWeapon(EWeaponTypes.Shotgun))));

            Console.WriteLine("     Iterating over RedSoldiers:");
            Printer.Print(redSoldiers);

            Console.WriteLine("-------------- Start War ------------------");
            BattleFieldFactory germany = new GermanBattleFieldFactory();
            LiveWar war = new LiveWar(germany,natziSoldiers,redSoldiers);
            war.StartWar(new GroundFightLogicStrategy());

            Console.WriteLine("     Iterating over NatziSoldiers After War");
            Printer.Print(natziSoldiers);

            Console.WriteLine("     Iterating over RedSoldiers  After War");
            Printer.Print(redSoldiers);
        }
    }
}
