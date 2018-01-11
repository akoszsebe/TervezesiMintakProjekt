using Project.WeaponDecorator;

namespace Project.SoldierBehaviors
{
    class DeadSoldierBehavior : SoldierBehavior
    {
        public DeadSoldierBehavior(IWeapon weapon) : base(0, weapon)
        {
        }

        public override void Attak(ref SoldierBehavior soldier, int multiplier)
        {
            
        }
    }
}
