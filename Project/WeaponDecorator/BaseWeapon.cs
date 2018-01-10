using System;
using System.Collections.Generic;
using System.Text;

namespace Project.WeaponDecorator
{
    class BaseWeapon : IWeapon
    {
        private EWeaponTypes weaponType { get; } = EWeaponTypes.Machine_gun;

        public BaseWeapon(EWeaponTypes weaponType)
        {
            this.weaponType = weaponType;
        }

        public void Aim_And_Fire()
        {
            Console.WriteLine(weaponType.ToString() +  "Aim and Fire");
        }
    }
}
