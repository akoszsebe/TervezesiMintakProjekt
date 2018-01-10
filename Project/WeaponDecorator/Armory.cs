using System;
using System.Collections.Generic;
using System.Text;

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
