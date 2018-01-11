using System;

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
            Console.WriteLine(weaponType.ToString() +  " Aim and Fire");
        }

        public string GetName()
        {
            return weaponType.ToString();
        }
    }
}
