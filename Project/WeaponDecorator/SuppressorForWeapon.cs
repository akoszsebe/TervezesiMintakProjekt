using System;

namespace Project.WeaponDecorator
{
    class SuppressorForWeapon : WeaponAccessory
    {
        public SuppressorForWeapon(IWeapon weapon) :base(weapon)
        {
        }

        public override void Aim_And_Fire()
        {
            Console.WriteLine("Supressor");
            base.Aim_And_Fire();
        }

        public override string GetName()
        {
            return base.GetName() + "SuppressorForWeapon;";
        }
    }
}
