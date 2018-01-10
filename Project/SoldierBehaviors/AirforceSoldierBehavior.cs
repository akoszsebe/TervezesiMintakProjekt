using Project.WeaponDecorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.SoldierBehaviors
{
    class AirforceSoldierBehavior : SoldierBehavior
    {
        public AirforceSoldierBehavior(IWeapon weapon) : base(10,weapon)
        {
        }
        public override void Attak(SoldierBehavior soldier)
        {
            soldier.health -= 15;
        }
    }
}
