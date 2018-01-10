using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
