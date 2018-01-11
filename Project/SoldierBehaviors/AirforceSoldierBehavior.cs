using Project.WeaponDecorator;

namespace Project.SoldierBehaviors
{
    class AirforceSoldierBehavior : SoldierBehavior
    {
        public AirforceSoldierBehavior(IWeapon weapon) : base(10,weapon)
        {
        }
        public override void Attak(ref SoldierBehavior soldier,int multiplier)
        {
            soldier.health -= 15* multiplier;
            if (soldier.health <= 0)
            {
                IWeapon tmpWeapon = soldier.GetWeapon();
                soldier = new DeadSoldierBehavior(tmpWeapon);
            };
        }
    }
}
