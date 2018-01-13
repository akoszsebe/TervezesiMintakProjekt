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
            MyCollection naziSoldiers = new MyCollection();
            naziSoldiers[0] = new Item(new AirforceSoldierBehavior(new BaseWeapon(EWeaponTypes.Submachine_gun)));
            naziSoldiers[1] = new Item(new AirforceSoldierBehavior(new SideSaddlesForWeapon(new SuppressorForWeapon(new BaseWeapon(EWeaponTypes.Marksman)))));
            naziSoldiers[2] = new Item(new NavyforceSoldierBehavior(new SideSaddlesForWeapon(new BaseWeapon(EWeaponTypes.Shotgun))));
            naziSoldiers[3] = new Item(new AirforceSoldierBehavior(new SideSaddlesForWeapon(new BaseWeapon(EWeaponTypes.Shotgun))));

            Console.WriteLine("     Iterating over NaziSoldiers:");
            Printer.Print(naziSoldiers);

            MyCollection redSoldiers = new MyCollection();
            redSoldiers[0] = new Item(new GroundforcesSoldierBehavior(new BaseWeapon(EWeaponTypes.Marksman)));
            redSoldiers[1] = new Item(new GroundforcesSoldierBehavior(new SuppressorForWeapon(new SuppressorForWeapon(new BaseWeapon(EWeaponTypes.Marksman)))));
            redSoldiers[2] = new Item(new AirforceSoldierBehavior(new SideSaddlesForWeapon(new BaseWeapon(EWeaponTypes.Shotgun))));
            redSoldiers[3] = new Item(new GroundforcesSoldierBehavior(new SideSaddlesForWeapon(new BaseWeapon(EWeaponTypes.Shotgun))));

            Console.WriteLine("     Iterating over RedSoldiers:");
            Printer.Print(redSoldiers);

            Console.WriteLine("-------------- Start Fight ------------------");

            BattleFieldFactory germany = new GermanBattleFieldFactory();
            LiveWar war = new LiveWar(germany,naziSoldiers,redSoldiers);
            war.StartWar(new GroundFightLogicStrategy());

            Console.WriteLine("     Iterating over NaziSoldiers After War");
            Printer.Print(naziSoldiers);

            Console.WriteLine("     Iterating over RedSoldiers  After War");
            Printer.Print(redSoldiers);
        }
    }
}
