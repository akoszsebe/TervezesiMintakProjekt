using Project.WeaponDecorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.SoldierBehaviors
{
    abstract class SoldierBehavior
    {
        public int health { get; set; }
        private IWeapon weapon { get; set; }

        protected SoldierBehavior(int starthealth,IWeapon weapon)
        {
            this.health = starthealth;
            this.weapon = weapon; 
        }

        public abstract void Attak(SoldierBehavior soldier);
    }
}
