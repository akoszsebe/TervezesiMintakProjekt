using System;

namespace Project.WeaponDecorator
{
    class SideSaddlesForWeapon : WeaponAccessory
    {
        public SideSaddlesForWeapon(IWeapon weapon) : base(weapon)
        {    
        }

        public override void Aim_And_Fire()
        {
            Console.WriteLine("SideSaddles");
            base.Aim_And_Fire();
        }

        public override string GetName()
        {
            return base.GetName() + "SideSaddlesForWeapon;";
        }
    }
}
