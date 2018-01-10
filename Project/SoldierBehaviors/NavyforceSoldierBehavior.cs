using Project.WeaponDecorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.SoldierBehaviors
{
    class NavyforceSoldierBehavior : SoldierBehavior
    {
        public NavyforceSoldierBehavior(IWeapon weapon) : base(20, weapon)
        {
        }
        public override void Attak(SoldierBehavior soldier)
        {
            soldier.health -= 10;
        }
    }
}
