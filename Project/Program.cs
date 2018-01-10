using Project.BattleFieldFactorys;
using Project.SoldierBehaviors;
using Project.WeaponDecorator;
using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Armory irak = new Armory();
            //irak.AddWeapon(new BaseWeapon(EWeaponTypes.Submachine_gun));
            //irak.AddWeapon(new SuppressorForWeapon(new BaseWeapon(EWeaponTypes.Sniper)));
            //irak.AddWeapon(new SideSaddlesForWeapon(new BaseWeapon(EWeaponTypes.Shotgun)));

            //irak.stock.ForEach(x => { x.Aim_And_Fire(); Console.WriteLine("---"); });

            List<SoldierBehavior> natziSoldiers = new List<SoldierBehavior>();
            List<SoldierBehavior> redSoldiers = new List<SoldierBehavior>();


            BattleFieldFactory germany = new GermanBattleFieldFactory();
            LiveWar war = new LiveWar(germany,natziSoldiers,redSoldiers);
            war.StartWar();


        }
    }
}
