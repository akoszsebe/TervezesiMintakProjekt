using Project.WeaponDecorator;

namespace Project.SoldierBehaviors
{
    class GroundforcesSoldierBehavior : SoldierBehavior
    {
        public GroundforcesSoldierBehavior(IWeapon weapon) : base(5,weapon)
        {
        }
        public override void Attak(ref SoldierBehavior soldier,int multiplier)
        {
            soldier.health -= 5*multiplier;
            if (soldier.health <= 0)
            {
                IWeapon tmpWeapon = soldier.GetWeapon();
                soldier = new DeadSoldierBehavior(tmpWeapon);
            };
        }
    }
}
