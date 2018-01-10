using System;
using System.Collections.Generic;
using System.Text;

namespace Project.WeaponDecorator
{
    class SideSaddlesForWeapon :WeaponAccessory
    {
        public SideSaddlesForWeapon(IWeapon weapon) : base(weapon)
        {    
        }

        public override void Aim_And_Fire()
        {
            Console.WriteLine("SideSaddles");
            base.Aim_And_Fire();
        }
    }
}
