using Project.WeaponDecorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.SoldierBehaviors
{
    class GroundforcesSoldierBehavior : SoldierBehavior
    {
        public GroundforcesSoldierBehavior(IWeapon weapon) : base(5,weapon)
        {
        }
        public override void Attak(SoldierBehavior soldier)
        {
            soldier.health -= 5;
        }
    }
}
