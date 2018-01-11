using System.Collections.Generic;

namespace Project.WeaponDecorator
{
    class Armory
    {
        public List<IWeapon> stock { get; }

        public Armory()
        {
            stock = new List<IWeapon>();
        }

        public void AddWeapon(IWeapon weapon)
        {
            stock.Add(weapon);
        }

    }
}
